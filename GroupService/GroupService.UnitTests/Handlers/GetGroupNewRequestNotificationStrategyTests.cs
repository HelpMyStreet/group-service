using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetGroupNewRequestNotificationStrategyTests
    {
        private GetGroupNewRequestNotificationStrategyHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private GetGroupNewRequestNotificationStrategyResponse _getGroupNewRequestNotificationStrategyResponse;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupNewRequestNotificationStrategy(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _getGroupNewRequestNotificationStrategyResponse);

            _classUnderTest = new GetGroupNewRequestNotificationStrategyHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdIsValid_ReturnStrategy()
        {
            _getGroupNewRequestNotificationStrategyResponse = new GetGroupNewRequestNotificationStrategyResponse()
            {
                MaxVolunteer = 10,
                NewRequestNotificationStrategy = HelpMyStreet.Utils.Enums.NewRequestNotificationStrategy.ClosestNEligibleVolunteers
            };
            var result = _classUnderTest.Handle(new GetGroupNewRequestNotificationStrategyRequest()
            {
                GroupID = 1
            },CancellationToken.None).Result;

            Assert.AreEqual(_getGroupNewRequestNotificationStrategyResponse, result);
        }

        [Test]
        public void WhenGroupIdIsInValid_ThrowsError()
        {
            int groupId = 1;
            _repository.Setup(x => x.GetGroupNewRequestNotificationStrategy(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Throws(new Exception($"Unable to find new request notification strategy for {groupId}"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetGroupNewRequestNotificationStrategyRequest()
            {
                GroupID = groupId
            }, CancellationToken.None));

            Assert.AreEqual($"Unable to find new request notification strategy for {groupId}", ex.Message);
        }
    }
}