using Castle.Core.Logging;
using GroupService.AzureFunction;
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
    public class PostRevokeRoleTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<PostRevokeRoleRequest>> _logger;
        private PostRevokeRole _classUnderTest;
        private PostRevokeRoleResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<PostRevokeRoleRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new PostRevokeRole(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsSuccess()
        {
            _response = new PostRevokeRoleResponse()
            {
                Outcome = GroupPermissionOutcome.Success
            };

            IActionResult result = await _classUnderTest.Run(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 1,
                Role = new RoleRequest() { GroupRole = GroupRoles.RequestSubmitter },
                AuthorisedByUserID = 2
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupPermissionOutcome.Success, deserialisedResponse.Content.Outcome);

            _mediator.Verify(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task UnHappyPath_ReturnsUnauthorized()
        {
            _response = new PostRevokeRoleResponse()
            {
                Outcome = GroupPermissionOutcome.Unauthorized
            };

            IActionResult result = await _classUnderTest.Run(new PostRevokeRoleRequest()
            {
                UserID = 1,
                GroupID = 1,
                Role = new RoleRequest() { GroupRole = GroupRoles.RequestSubmitter },
                AuthorisedByUserID = 2
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, deserialisedResponse.Content.Outcome);

            _mediator.Verify(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task MissingParameters_ThrowsValidationError()
        {
            PostRevokeRoleRequest req = new PostRevokeRoleRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(4, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public async Task MissingUserID_ThrowsValidationError()
        {
            PostRevokeRoleRequest req = new PostRevokeRoleRequest()
            {
                AuthorisedByUserID = 1,
                GroupID = 2,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Owner
                }
            };

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public async Task MissingGroupID_ThrowsValidationError()
        {
            PostRevokeRoleRequest req = new PostRevokeRoleRequest()
            {
                AuthorisedByUserID = 1,
                UserID = 1,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Owner
                }
            };

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public async Task MissingAuthorisedByUserID_ThrowsValidationError()
        {
            PostRevokeRoleRequest req = new PostRevokeRoleRequest()
            {
                GroupID = 1,
                UserID = 1,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Owner
                }
            };

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostRevokeRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
