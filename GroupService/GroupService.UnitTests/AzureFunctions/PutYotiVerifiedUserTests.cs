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
    public class PutYotiVerifiedUserTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<PutYotiVerifiedUserRequest>> _logger;
        private PutYotiVerifiedUser _classUnderTest;
        private bool _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<PutYotiVerifiedUserRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<PutYotiVerifiedUserRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new PutYotiVerifiedUser(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsSuccess()
        {
            _response = true;

            IActionResult result = await _classUnderTest.Run(new PutYotiVerifiedUserRequest()
            {
                UserId = 1,
                Notes = "",
                Reference = ""
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

            _mediator.Verify(x => x.Send(It.IsAny<PutYotiVerifiedUserRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
