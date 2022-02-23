using GroupService.AzureFunction;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using GroupService.Handlers;
using HelpMyStreet.Contracts.CommunicationService.Request;
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
    public class PostAssignRoleHandlerTests
    {
        private PostAssignRoleHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Mock<ICommunicationService> _communicationService;

        private bool _success;
        private bool _roleAssignedSecondCall;
        private bool _allowAutonomousJoinersAndLeavers;
        private bool _roleAssignedFirstCall;
        private bool _allowRoleChange;

        [SetUp]
        public void Setup()
        {
            _roleAssignedSecondCall = false;
            _repository = new Mock<IRepository>();

            _repository.Setup(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _success);

            _repository.SetupSequence(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()))
                .Returns(() => _roleAssignedFirstCall)
                .Returns(() => _roleAssignedSecondCall);

            _repository.Setup(x => x.GetSecurityConfiguration(It.IsAny<int>()))
                .Returns(() => new Core.Domains.Entities.SecurityConfiguration() { AllowAutonomousJoinersAndLeavers = _allowAutonomousJoinersAndLeavers });

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

            _communicationService = new Mock<ICommunicationService>();
               
            _classUnderTest = new PostAssignRoleHandler(_repository.Object, _communicationService.Object);               
        }

        private void VerifySuccess(GroupRoles role, GroupPermissionOutcome outcome, bool alreadyAssigned=false)
        {
            Assert.AreEqual(GroupPermissionOutcome.Success, outcome);
            if (!alreadyAssigned)
            {
                _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            }
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), GroupRoles.Member, It.IsAny<CancellationToken>()), Times.Once);
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

        private void VerifyFailure(GroupRoles role, GroupPermissionOutcome outcome, bool passedExistingRoleCheck = true)
        {
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, outcome);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), GroupRoles.Member, It.IsAny<CancellationToken>()), Times.Once);
            if (passedExistingRoleCheck)
            {
                _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), role, It.IsAny<CancellationToken>()), Times.Once);           
                _repository.Verify(x => x.AllowRoleChange(It.IsAny<GroupRoles>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            }
            _repository.Verify(x => x.AddUserRoleAudit(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);

            _communicationService.Verify(x => x.RequestCommunication(It.IsAny<RequestCommunicationRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedByUserID_ReturnSuccess()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _roleAssignedFirstCall = true;
            _success = true;
            _allowRoleChange = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            VerifySuccess(role, result.Result.Outcome);
        }

        [Test]
        public void WhenRoleIsAssigned_ReturnSuccess()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _roleAssignedFirstCall = true;
            _roleAssignedSecondCall = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            VerifySuccess(role, result.Result.Outcome, true);            
            _communicationService.Verify(x => x.RequestCommunication(It.IsAny<RequestCommunicationRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedBySystem_ReturnSuccess()
        {
            _roleAssignedSecondCall = false;
            _roleAssignedFirstCall = true;
            GroupRoles role = GroupRoles.RequestSubmitter;
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = -1,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);

            VerifySuccess(role, result.Result.Outcome);
            _communicationService.Verify(x => x.RequestCommunication(It.IsAny<RequestCommunicationRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditions_ReturnSuccess()
        {
            GroupRoles role = GroupRoles.Member;
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;
            _roleAssignedFirstCall = false;
            _roleAssignedSecondCall = false;
            _allowRoleChange = false;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 1,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            VerifySuccess(role, result.Result.Outcome);            
            _communicationService.Verify(x => x.RequestCommunication(It.IsAny<RequestCommunicationRequest>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
        }

        [Test]
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditionsButWrongUser_ReturnUnauthorized()
        {
            GroupRoles role = GroupRoles.TaskAdmin;
            _roleAssignedFirstCall = true;
            _success = true;
            _roleAssignedSecondCall = false;
            _allowRoleChange = false;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);

            VerifyFailure(role, result.Result.Outcome);
        }

        [Test]
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditionsButWrongRole_ReturnUnauthorized()
        {
            _roleAssignedFirstCall = true;
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;
            _allowRoleChange = false;

            GroupRoles role = GroupRoles.UserAdmin;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 1,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            VerifyFailure(role, result.Result.Outcome);
        }

        [Test]
        public void WhenRequestIsValid_ReturnUnauthorized()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _roleAssignedFirstCall = true;
            _success = true;
            _allowRoleChange = false;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            VerifyFailure(role, result.Result.Outcome);
        }

        [Test]
        public void WhenUserIsNotMember_ReturnUnauthorized()
        {
            GroupRoles role = GroupRoles.RequestSubmitter;
            _roleAssignedFirstCall = false;
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = role
                }
            }, CancellationToken.None);
            VerifyFailure(role, result.Result.Outcome, false);
        }

    }
}