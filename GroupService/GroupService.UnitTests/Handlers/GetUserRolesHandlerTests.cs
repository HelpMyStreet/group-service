using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetUserRolesHandlerTests
    {
        private GetUserRolesHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Dictionary<int,List<int>> _groups;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetUserRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);

            _classUnderTest = new GetUserRolesHandler(_repository.Object);
               
        }

        [Test]
        public void WhenUserNameIsValid_ReturnUserRoles()
        {
            int userId = 1;
            _groups = new Dictionary<int, List<int>>();
            _groups.Add(1, new List<int>
            {
                1,
                2
            });
            _groups.Add(2, new List<int>
            {
                2
            });

            var result = _classUnderTest.Handle(new GetUserRolesRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_groups.Count, result.UserGroupRoles.Count);
            Assert.AreEqual(_groups, result.UserGroupRoles);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void UserWithoutGroups_ReturnsEmptyDictionary()
        {
            int userId = 1;
            _groups = new Dictionary<int, List<int>>();
            var result = _classUnderTest.Handle(new GetUserRolesRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            Assert.AreEqual(0, result.UserGroupRoles.Count);
            Assert.AreEqual(_groups, result.UserGroupRoles);
            _repository.Verify(x => x.GetUserRoles(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}