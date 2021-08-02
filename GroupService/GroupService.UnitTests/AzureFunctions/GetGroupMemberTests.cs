using Castle.Core.Logging;
using GroupService.AzureFunction;
using GroupService.Core.Exception;
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
    public class GetGroupMemberTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupMember>> _logger;
        private GetGroupMember _classUnderTest;
        private GetGroupMemberResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupMember>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupMemberRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new GetGroupMember(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsUsers()
        {
            UserInGroup userInGroup = new UserInGroup();

            _response = new GetGroupMemberResponse()
            {
                UserInGroup = userInGroup
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupMemberRequest()
            {
                UserId = 1,
                GroupId = 1,
                AuthorisingUserId = 1
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupMemberResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMemberResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(userInGroup, deserialisedResponse.Content.UserInGroup);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMemberRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task UnauthorisedUser_ThrowsUnauthorisedError()
        {
            GetGroupMemberRequest req = new GetGroupMemberRequest()
            {
                UserId = 1,
                GroupId = 1,
                AuthorisingUserId = 2
            };

            _mediator.Setup(x => x.Send(It.IsAny<GetGroupMemberRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new UnauthorisedException());

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(401, objectResult.StatusCode);

            ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.UnauthorisedError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMemberRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

    }
}
