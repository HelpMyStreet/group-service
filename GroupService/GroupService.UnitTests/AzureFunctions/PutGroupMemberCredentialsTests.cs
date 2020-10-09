using Castle.Core.Logging;
using GroupService.AzureFunction;
using GroupService.Core.Exception;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests.AzureFunctions
{
    public class PutGroupMemberCredentialsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<PutGroupMemberCredentialsRequest>> _logger;
        private PutGroupMemberCredentials _classUnderTest;
        private bool _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<PutGroupMemberCredentialsRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<PutGroupMemberCredentialsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new PutGroupMemberCredentials(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsSuccess()
        {
            _response = true;

            IActionResult result = await _classUnderTest.Run(new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<bool, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<bool, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(_response, deserialisedResponse.Content);

            _mediator.Verify(x => x.Send(It.IsAny<PutGroupMemberCredentialsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task UnHappyPath_ReturnsUnauthorized()
        {
            _response = false;
            PutGroupMemberCredentialsRequest req = new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            };

            _mediator.Setup(x => x.Send(It.IsAny<PutGroupMemberCredentialsRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new UnauthorisedException());

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);
            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(401, objectResult.StatusCode);

            ResponseWrapper<bool, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<bool, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.UnauthorisedError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PutGroupMemberCredentialsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
