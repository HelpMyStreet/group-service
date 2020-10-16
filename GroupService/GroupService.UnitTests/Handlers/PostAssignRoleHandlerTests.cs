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
    public class PostAssignRoleHandlerTests
    {
        private PostAssignRoleHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private int _groupId;
        private Dictionary<int, List<int>> _allUserRoles;
        private bool _success;
        private bool _roleAssigned;
        private bool _allowAutonomousJoinersAndLeavers;
        private bool _roleMemberOrVolunteerAssigned;

        [SetUp]
        public void Setup()
        {
            _roleAssigned = false;
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() => _allUserRoles);

            _repository.Setup(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _success);

            _repository.Setup(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _roleMemberOrVolunteerAssigned);

            _repository.Setup(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()))
                .Returns(() => _roleAssigned);


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
               
            _classUnderTest = new PostAssignRoleHandler(_repository.Object);
               
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedByUserID_ReturnSuccess()
        {
            _roleMemberOrVolunteerAssigned = true;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allUserRoles.Add(1, new List<int>
            {
                1,2
            });
            _allUserRoles.Add(2, new List<int>
            {
                (int) GroupRoles.Owner
            });
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.RequestSubmitter
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);

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
        public void WhenRoleIsAssigned_ReturnSuccess()
        {
            _roleMemberOrVolunteerAssigned = true;
            _roleAssigned = true;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allUserRoles.Add(1, new List<int>
            {
                1,2
            });
            _allUserRoles.Add(2, new List<int>
            {
                (int) GroupRoles.Owner
            });
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.RequestSubmitter
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);

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
            _roleAssigned = false;
            _roleMemberOrVolunteerAssigned = true;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allUserRoles.Add(1, new List<int>
            {
                1,2
            });
            _allUserRoles.Add(2, new List<int>
            {
                (int) GroupRoles.Owner,
                (int) GroupRoles.Member
            });
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = -1,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.RequestSubmitter
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Success, result.Result.Outcome);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
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
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditions_ReturnSuccess()
        {
            _allUserRoles = new Dictionary<int, List<int>>();
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
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
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
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
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditionsButWrongUser_ReturnUnauthorized()
        {
            _roleMemberOrVolunteerAssigned = true;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;
            _roleAssigned = false;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Member
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
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
        public void WhenRequestIsValidAndGroupAllowsAutonomousAdditionsButWrongRole_ReturnUnauthorized()
        {
            _roleMemberOrVolunteerAssigned = true;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allowAutonomousJoinersAndLeavers = true;
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
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
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
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
            _roleMemberOrVolunteerAssigned = true;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allUserRoles.Add(1, new List<int>
            {
                1,2
            });
            _allUserRoles.Add(2, new List<int>
            {
                (int) GroupRoles.RequestSubmitter
            });
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.RequestSubmitter
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
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
        public void WhenUserIsNotMember_ReturnUnauthorized()
        {
            _roleMemberOrVolunteerAssigned = false;
            _allUserRoles = new Dictionary<int, List<int>>();
            _allUserRoles.Add(1, new List<int>
            {
                1,2
            });
            _allUserRoles.Add(2, new List<int>
            {
                (int) GroupRoles.RequestSubmitter
            });
            _success = true;

            var result = _classUnderTest.Handle(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 2,
                AuthorisedByUserID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.RequestSubmitter
                }
            }, CancellationToken.None);
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, result.Result.Outcome);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleMemberAssignedForUserInGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
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