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
    public class GetGroupMembersHandlerTests
    {
        private GetGroupMembersHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<int> _users;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupMembers(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _users);

            _classUnderTest = new GetGroupMembersHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupNameIsValid_ReturnGroups()
        {
            int groupId = 1;
            _users = new List<int>();
            _users.Add(1);
            _users.Add(2);
            _users.Add(3);
            var result = _classUnderTest.Handle(new GetGroupMembersRequest()
            {
                GroupID = groupId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_users.Count, result.Users.Count);
            Assert.AreEqual(_users, result.Users);
            _repository.Verify(x => x.GetGroupMembers(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}