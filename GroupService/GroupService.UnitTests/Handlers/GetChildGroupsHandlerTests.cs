using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetChildGroupsHandlerTests
    {
        private GetChildGroupsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<Group> _groups;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);

            _classUnderTest = new GetChildGroupsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdIsValid_ReturnChildGroups()
        {
            _groups = new List<Group>()
            {
               new Group()
               { 
                    GroupId = 1,
                    GroupKey = "GroupKey",
                    GroupName = "GroupName"
               },
               new Group()
               { 
                    GroupId = 2,
                    GroupKey = "GroupKey2",
                    GroupName = "GroupName2"
               },
            };


            var result = _classUnderTest.Handle(new GetChildGroupsRequest()
            {
                GroupID = 1
            },CancellationToken.None).Result;

            Assert.AreEqual(_groups, result.ChildGroups);
        }

        [Test]
        public void WhenGroupIdIsInValid_ThrowsError()
        {
            int groupId = 1;
            _repository.Setup(x => x.GetChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Throws(new Exception($"{groupId} not found"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetChildGroupsRequest()
            {
                GroupID = groupId
            }, CancellationToken.None));

            Assert.AreEqual($"{groupId} not found", ex.Message);
        }
    }
}