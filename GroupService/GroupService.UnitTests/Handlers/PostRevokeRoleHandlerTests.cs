using GroupService.AzureFunction;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class PostRevokeRoleHandlerTests
    {
        private PostRevokeRoleHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private bool _success;
        private bool _roleAssigned;
        private bool _allowAutonomousJoinersAndLeavers;
        private bool _userHasOtherRoles;
        private bool _allowRoleChange;

        [SetUp]
        public void Setup()
        {
            _roleAssigned = true;
            _repository = new Mock<IRepository>();

            _repository.Setup(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _success);

            _repository.Setup(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()))
                .Returns(() => _roleAssigned);

            _repository.Setup(x => x.GetSecurityConfiguration(It.IsAny<int>()))
                .Returns(() => new Core.Domains.Entities.SecurityConfiguration() { AllowAutonomousJoinersAndLeavers = _allowAutonomousJoinersAndLeavers });

            _repository.Setup(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _userHasOtherRoles);

            _repository.Setup(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()));

            _repository.Setup(x => x.AllowRoleChange(
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .Returns(() => _allowRoleChange);

            _classUnderTest = new PostRevokeRoleHandler(_repository.Object);
               
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedByUserID_ReturnSuccess()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _userHasOtherRoles = false;
            _success = true;
            _allowRoleChange = true;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), role, It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public void WhenRoleDoesNotExist_ReturnSuccess()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _userHasOtherRoles = false;
            _roleAssigned = false;
            _allowRoleChange = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedBySystem_ReturnSuccess()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _userHasOtherRoles = false;
            _success = true;
            _allowRoleChange = false;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = -1,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), role, It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditions_ReturnSuccess()
        {
            _userHasOtherRoles = false;
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 1,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Member
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), GroupRoles.Member, It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditionsButWrongUser_ReturnUnauthorized()
        {
            GroupRoles role = GroupRoles.Member;
            _userHasOtherRoles = false;
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), role, It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditionsButWrongRole_ReturnUnauthorized()
        {
            _userHasOtherRoles = false;
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;
            _allowRoleChange = false;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 1,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.UserAdmin
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void WhenRequestIsValid_ReturnUnauthorized()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _userHasOtherRoles = false;
            _success = true;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), role, It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void WhenUserRevokesMemberAndHasOtherRoles_ReturnUnauthorized()
        {
            GroupRoles role = GroupRoles.Member;
            _userHasOtherRoles = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.UserHasRolesOtherThanVolunteerAndMember(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

    }
}