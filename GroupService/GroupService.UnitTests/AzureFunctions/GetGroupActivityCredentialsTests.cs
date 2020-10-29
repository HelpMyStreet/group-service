using Castle.Core.Logging;
using GroupService.AzureFunction;
using GroupService.Core.Exception;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Utils.Enums;
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
    public class GetGroupActivityCredentialsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupActivityCredentialsRequest>> _logger;
        private GetGroupActivityCredentials _classUnderTest;
        private GetGroupActivityCredentialsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupActivityCredentialsRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupActivityCredentialsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new GetGroupActivityCredentials(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroupDetails()
        {
            List<List<int>> credentialSets = new List<List<int>>();

            _response = new GetGroupActivityCredentialsResponse()
            {
                CredentialSets = credentialSets
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupActivityCredentialsRequest()
            { 
                GroupId = 1,
                SupportActivityType = new SupportActivityType() { SupportActivity = HelpMyStreet.Utils.Enums.SupportActivities.Shopping}
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupActivityCredentialsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupActivityCredentialsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(credentialSets, deserialisedResponse.Content.CredentialSets);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupActivityCredentialsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task UnHappyPath_ReturnsUnauthorized()
        {
            int groupId = 1;
            SupportActivities activity = SupportActivities.Shopping;

            GetGroupActivityCredentialsRequest req = new GetGroupActivityCredentialsRequest()
            {
                GroupId = groupId,
                SupportActivityType = new SupportActivityType() { SupportActivity = activity }
            };

            _mediator.Setup(x => x.Send(It.IsAny<GetGroupActivityCredentialsRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception($"Unable to retrieve credential set for GroupID={groupId} and supportActivity={activity.ToString()}"));

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);
            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            ResponseWrapper<GetGroupActivityCredentialsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupActivityCredentialsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.InternalServerError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupActivityCredentialsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
