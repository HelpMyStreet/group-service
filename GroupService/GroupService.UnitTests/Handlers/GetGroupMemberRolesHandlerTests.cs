using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetGroupMemberRolesHandlerTests
    {
        private GetGroupMemberRolesHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Dictionary<int,List<int>> _roles;
        private bool _isAdmin;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupMemberRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _roles);

            _repository.Setup(x => x.UserIsAdminForGroup(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => _isAdmin);


            _classUnderTest = new GetGroupMemberRolesHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIsValid_ReturnRoles()
        {
            int userId = 1;
            int groupId = 1;
            _isAdmin = true;

            _roles = new Dictionary<int, List<int>>();
            _roles.Add(1, new List<int>
            {
                1,
                2
            });
            _roles.Add(2, new List<int>
            {
                2
            });

            var result = _classUnderTest.Handle(new GetGroupMemberRolesRequest()
            {
                GroupId = groupId,
                UserId = userId,

            }, CancellationToken.None).Result;

            Assert.AreEqual(_roles.Count, result.GroupMemberRoles.Count);
            Assert.AreEqual(_roles, result.GroupMemberRoles);
            _repository.Verify(x => x.GetGroupMemberRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.UserIsAdminForGroup(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenGroupIsValidAndUserIsAdmin_ReturnRoles()
        {
            int userId = -1;
            int groupId = 1;
            _isAdmin = true;

            _roles = new Dictionary<int, List<int>>();
            _roles.Add(1, new List<int>
            {
                1,
                2
            });
            _roles.Add(2, new List<int>
            {
                2
            });

            var result = _classUnderTest.Handle(new GetGroupMemberRolesRequest()
            {
                GroupId = groupId,
                UserId = userId,

            }, CancellationToken.None).Result;

            Assert.AreEqual(_roles.Count, result.GroupMemberRoles.Count);
            Assert.AreEqual(_roles, result.GroupMemberRoles);
            _repository.Verify(x => x.GetGroupMemberRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.UserIsAdminForGroup(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void WhenGroupIsValidButUserIsNotAdmin_ReturnRoles()
        {
            int userId = 1;
            int groupId = 1;
            _isAdmin = false;

            _roles = null;

            var result = _classUnderTest.Handle(new GetGroupMemberRolesRequest()
            {
                GroupId = groupId,
                UserId = userId,

            }, CancellationToken.None).Result;

            Assert.AreEqual(_roles, result);
            _repository.Verify(x => x.GetGroupMemberRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Never);
            _repository.Verify(x => x.UserIsAdminForGroup(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void UserWithoutGroups_ReturnsNull()
        {
            int userId = 1;
            int groupId = 1;
            _isAdmin = true;
            _roles = null;
            var result = _classUnderTest.Handle(new GetGroupMemberRolesRequest()
            {
                GroupId = groupId,
                UserId = userId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_roles, result.GroupMemberRoles);
            _repository.Verify(x => x.GetGroupMemberRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.UserIsAdminForGroup(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
    }
}