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
    public class GetUserGroupsHandlerTests
    {
        private GetUserGroupsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<int> _groups;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);

            _classUnderTest = new GetUserGroupsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenUserNameIsValid_ReturnGroups()
        {
            int userId = 1;
            _groups = new List<int>();
            _groups.Add(1);
            _groups.Add(2);
            _groups.Add(3);
            var result = _classUnderTest.Handle(new GetUserGroupsRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_groups.Count, result.Groups.Count);
            Assert.AreEqual(_groups, result.Groups);
            _repository.Verify(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}