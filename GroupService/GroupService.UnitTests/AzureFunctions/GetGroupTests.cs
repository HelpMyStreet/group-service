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
    public class GetGroupTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupRequest>> _logger;
        private GetGroup _classUnderTest;
        private GetGroupResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetGroup(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroup()
        {
            int groupId = 1;
            Group group = new Group()
            {
                GroupId = groupId,
                GroupKey = "GroupKey",
                GroupName = "GroupName"
            };
            _response = new GetGroupResponse()
            {
               Group = group
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupRequest()
            {
                GroupID = groupId
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(group, deserialisedResponse.Content.Group);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task MissingGroupId_ThrowsValidationError()
        {
            GetGroupRequest req = new GetGroupRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<GetGroupResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
