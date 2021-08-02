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
    public class GetGroupMemberDetailsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupMemberDetails>> _logger;
        private GetGroupMemberDetails _classUnderTest;
        private GetGroupMemberDetailsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupMemberDetails>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupMemberDetailsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new GetGroupMemberDetails(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroupDetails()
        {
            UserInGroup userInGroup = new UserInGroup();
            List<GroupRoles> roles = new List<GroupRoles>();
            List<UserRoleAudit> audits = new List<UserRoleAudit>();
            List<UserCredential> credentials = new List<UserCredential>();

            _response = new GetGroupMemberDetailsResponse()
            {
                GroupRoles = roles,
                UserRoleAudits = audits,
                UserCredentials = credentials
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupMemberDetailsRequest()
            {
                UserId = 1,
                GroupId = 1,
                AuthorisingUserId = 1
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(roles, deserialisedResponse.Content.GroupRoles);
            Assert.AreEqual(audits, deserialisedResponse.Content.UserRoleAudits);
            Assert.AreEqual(credentials, deserialisedResponse.Content.UserCredentials);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMemberDetailsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task UnauthorisedUser_ThrowsUnauthorisedError()
        {
            GetGroupMemberDetailsRequest req = new GetGroupMemberDetailsRequest()
            {
                UserId = 1,
                GroupId = 1,
                AuthorisingUserId = 2
            };

            _mediator.Setup(x => x.Send(It.IsAny<GetGroupMemberDetailsRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new UnauthorisedException());

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(401, objectResult.StatusCode);

            ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.UnauthorisedError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMemberDetailsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

    }
}
