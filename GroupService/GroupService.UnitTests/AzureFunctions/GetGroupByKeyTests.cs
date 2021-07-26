using Castle.Core.Logging;
using GroupService.AzureFunction;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Contracts.Shared;
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
    public class GetGroupByKeyTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupByKey>> _logger;
        private GetGroupByKey _classUnderTest;
        private GetGroupByKeyResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupByKey>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetGroupByKey(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroup()
        {
            int groupId = 1;
            _response = new GetGroupByKeyResponse()
            {
                GroupId = groupId
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupByKeyRequest()
            {
                GroupKey = "GroupKey"
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupByKeyResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupByKeyResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(groupId, deserialisedResponse.Content.GroupId);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task MissingGroupKey_ThrowsValidationError()
        {
            GetGroupByKeyRequest req = new GetGroupByKeyRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<GetGroupByKeyResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupByKeyResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
