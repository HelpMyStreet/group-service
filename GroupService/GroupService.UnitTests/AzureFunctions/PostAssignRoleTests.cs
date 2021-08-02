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
    public class PostAssignRoleTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<PostAssignRole>> _logger;
        private PostAssignRole _classUnderTest;
        private PostAssignRoleResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<PostAssignRole>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new PostAssignRole(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsSuccess()
        {
            _response = new PostAssignRoleResponse()
            {
                Outcome = GroupPermissionOutcome.Success
            };

            IActionResult result = await _classUnderTest.Run(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 1,
                Role = new RoleRequest() { GroupRole = GroupRoles.RequestSubmitter },
                AuthorisedByUserID = 2
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupPermissionOutcome.Success, deserialisedResponse.Content.Outcome);

            _mediator.Verify(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task UnHappyPath_ReturnsUnauthorized()
        {
            _response = new PostAssignRoleResponse()
            {
                Outcome = GroupPermissionOutcome.Unauthorized
            };

            IActionResult result = await _classUnderTest.Run(new PostAssignRoleRequest()
            {
                UserID = 1,
                GroupID = 1,
                Role = new RoleRequest() { GroupRole = GroupRoles.RequestSubmitter },
                AuthorisedByUserID = 2
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupPermissionOutcome.Unauthorized, deserialisedResponse.Content.Outcome);

            _mediator.Verify(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task MissingParameters_ThrowsValidationError()
        {
            PostAssignRoleRequest req = new PostAssignRoleRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(4, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public async Task MissingUserID_ThrowsValidationError()
        {
            PostAssignRoleRequest req = new PostAssignRoleRequest()
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

            ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public async Task MissingGroupID_ThrowsValidationError()
        {
            PostAssignRoleRequest req = new PostAssignRoleRequest()
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

            ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [Test]
        public async Task MissingAuthorisedByUserID_ThrowsValidationError()
        {
            PostAssignRoleRequest req = new PostAssignRoleRequest()
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

            ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAssignRoleResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
