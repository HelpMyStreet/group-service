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
    public class GetGroupMemberRolesTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupMemberRolesRequest>> _logger;
        private GetGroupMemberRoles _classUnderTest;
        private GetGroupMemberRolesResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupMemberRolesRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupMemberRolesRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetGroupMemberRoles(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsUsers()
        {
            Dictionary<int, List<int>> roles =  new Dictionary<int, List<int>>();
            roles.Add(1, new List<int>
            {
                1,
                2
            });
            roles.Add(2, new List<int>
            {
                2
            });
            _response = new GetGroupMemberRolesResponse()
            {
                GroupMemberRoles = roles
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupMemberRolesRequest()
            {
                UserId = 1,
                GroupId = 1,
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupMemberRolesResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMemberRolesResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(roles, deserialisedResponse.Content.GroupMemberRoles);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMemberRolesRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task NonAdminUserId_ReturnsNull()
        {
            GetGroupMemberRolesRequest req = new GetGroupMemberRolesRequest()
            {
                UserId = 1,
                GroupId = 1
            };

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupMemberRolesResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupMemberRolesResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupMemberRolesRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

    }
}
