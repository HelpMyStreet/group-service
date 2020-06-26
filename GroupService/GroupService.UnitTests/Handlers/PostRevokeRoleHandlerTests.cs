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
        private Dictionary<int, List<int>> _allUserRoles;
        private bool _success;
        private bool _roleAssigned;
        [SetUp]
        public void Setup()
        {
            _roleAssigned = true;
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetUserRoles(It.IsAny<GetUserRolesRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() => _allUserRoles);

            _repository.Setup(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _success);

            _repository.Setup(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()))
                .Returns(() => _roleAssigned);

            _repository.Setup(x => x.AddUserRoleAuditAsync(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()));

            _classUnderTest = new PostRevokeRoleHandler(_repository.Object);
               
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedByUserID_ReturnSuccess()
        { 
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

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
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
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAuditAsync(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void WhenRoleDoesNotExist_ReturnSuccess()
        {
            _roleAssigned = false;
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

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
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
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAuditAsync(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>(),
                It.IsAny<int>(),
                It.IsAny<GroupAction>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }


        public void WhenRequestIsValidAndAuthorisedBySystem_ReturnSuccess()
        {
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

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
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
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAuditAsync(
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

            var result = _classUnderTest.Handle(new PostRevokeRoleRequest()
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
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.RoleAssigned(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.AddUserRoleAuditAsync(
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