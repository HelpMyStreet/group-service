using Castle.Core.Logging;
using GroupService.AzureFunction;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests.AzureFunctions
{
    public class GetGroupNewRequestNotificationStrategyTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupNewRequestNotificationStrategyRequest>> _logger;
        private GetGroupNewRequestNotificationStrategy _classUnderTest;
        private GetGroupNewRequestNotificationStrategyResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupNewRequestNotificationStrategyRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupNewRequestNotificationStrategyRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetGroupNewRequestNotificationStrategy(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsStrategy()
        {
            int groupId = 1;
            _response = new GetGroupNewRequestNotificationStrategyResponse()
            {
               MaxVolunteer = 10,
               NewRequestNotificationStrategy = HelpMyStreet.Utils.Enums.NewRequestNotificationStrategy.ClosestNEligibleVolunteers
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupNewRequestNotificationStrategyRequest()
            {
                GroupID = groupId
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(_response, deserialisedResponse.Content);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupNewRequestNotificationStrategyRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task MissingGroupId_ThrowsValidationError()
        {
            GetGroupNewRequestNotificationStrategyRequest req = new GetGroupNewRequestNotificationStrategyRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupNewRequestNotificationStrategyRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
