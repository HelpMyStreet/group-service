using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetGroupHandlerTests
    {
        private GetGroupHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Group _group;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _group);

            _classUnderTest = new GetGroupHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdIsValid_ReturnGroup()
        {
            _group = new Group()
            {
                GroupId = 1,
                GroupKey = "GroupKey",
                GroupName = "GroupName"
            };
            var result = _classUnderTest.Handle(new GetGroupRequest()
            {
                GroupID = 1
            },CancellationToken.None).Result;

            Assert.AreEqual(_group, result.Group);
        }

        [Test]
        public void WhenGroupIdIsInValid_ThrowsError()
        {
            int groupId = 1;
            _repository.Setup(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Throws(new Exception($"{groupId} not found"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetGroupRequest()
            {
                GroupID = groupId
            }, CancellationToken.None));

            Assert.AreEqual($"{groupId} not found", ex.Message);
        }
    }
}