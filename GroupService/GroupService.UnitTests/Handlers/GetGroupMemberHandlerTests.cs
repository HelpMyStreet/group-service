using GroupService.Core.Exception;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;

namespace GroupService.UnitTests
{
    public class GetGroupMemberHandlerTests
    {
        private GetGroupMemberHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private UserInGroup _userInGroup;
        private bool _hasPermission;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupMember(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => _userInGroup);

            _repository.Setup(x => x.UserIsInRoleForGroup(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<GroupRoles>()))
                .Returns(() => _hasPermission);

            _classUnderTest = new GetGroupMemberHandler(_repository.Object);
               
        }

        [Test]
        public void WhenUserIDAndAuthorisingUserIDAreTheSame_ReturnUserDetails()
        {
            int groupId = 1;
            int userId = 1;

            _userInGroup = new UserInGroup()
            {
                UserId = userId,
                GroupId = groupId,
                GroupRoles = new List<GroupRoles>()
                { GroupRoles.Member},
                ValidCredentials = new List<int>()
                {
                    -1
                }
            };

            var result = _classUnderTest.Handle(new GetGroupMemberRequest()
            {
                GroupId = groupId,
                UserId = userId,
                AuthorisingUserId = userId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_userInGroup, result.UserInGroup);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Never);
            _repository.Verify(x => x.GetGroupMember(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenUserIDAndAuthorisingUserIDAreDifferentAndAuthorisingIsAdmin_ReturnUserDetails()
        {
            int groupId = 1;
            int userId = 1;
            int authorisingUserId = 2;
            _hasPermission = true;

            _userInGroup = new UserInGroup()
            {
                UserId = userId,
                GroupId = groupId,
                GroupRoles = new List<GroupRoles>()
                { GroupRoles.Member},
                ValidCredentials = new List<int>()
                {
                    -1
                }
            };

            var result = _classUnderTest.Handle(new GetGroupMemberRequest()
            {
                GroupId = groupId,
                UserId = userId,
                AuthorisingUserId = authorisingUserId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_userInGroup, result.UserInGroup);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Once);
            _repository.Verify(x => x.GetGroupMember(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenUserIDAndAuthorisingUserIDAreDifferentAndAuthorisingIsNotAdmin_ReturnsException()
        {
            int groupId = 1;
            int userId = 1;
            int authorisingUserId = 2;
            _hasPermission = false;

            Assert.ThrowsAsync<UnauthorisedException>(() => _classUnderTest.Handle(new GetGroupMemberRequest()
            {
                GroupId = groupId,
                UserId = userId,
                AuthorisingUserId = authorisingUserId
            }, CancellationToken.None));
;
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Once);
            _repository.Verify(x => x.GetGroupMember(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }
    }
}