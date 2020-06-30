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
    public class GetGroupMembersTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupMembersRequest>> _logger;
        private GetGroupMembers _classUnderTest;
        private GetGroupMembersResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupMembersRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupMembersRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetGroupMembers(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsUsers()
        {
            List<int> users = new List<int>();
            users.Add(1);
            users.Add(2);
            users.Add(3);

            _response = new GetGroupMembersResponse()
            {
                Users = users
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupMembersRequest()
            {
                GroupID = 1
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(users, deserialisedResponse.Content.Users);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMembersRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task MissingGroupId_ThrowsValidationError()
        {
            GetGroupMembersRequest req = new GetGroupMembersRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMembersRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
