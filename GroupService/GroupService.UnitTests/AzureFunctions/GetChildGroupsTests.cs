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
    public class GetChildGroupsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetChildGroups>> _logger;
        private GetChildGroups _classUnderTest;
        private GetChildGroupsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetChildGroups>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetChildGroupsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetChildGroups(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroup()
        {
            List<Group> groups = new List<Group>
            {
                new Group()
                {
                    GroupId = 1,
                    GroupKey = "GroupKey",
                    GroupName = "GroupName"
                },
                new Group()
                {
                    GroupId = 2,
                    GroupKey = "GroupKey2",
                    GroupName = "GroupName2"
                }
            };

            _response = new GetChildGroupsResponse()
            {
               ChildGroups = groups
            };

            IActionResult result = await _classUnderTest.Run(new GetChildGroupsRequest()
            {
                GroupID = 1
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetChildGroupsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetChildGroupsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(groups, deserialisedResponse.Content.ChildGroups);

            _mediator.Verify(x => x.Send(It.IsAny<GetChildGroupsRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task MissingGroupId_ThrowsValidationError()
        {
            GetChildGroupsRequest req = new GetChildGroupsRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<GetChildGroupsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetChildGroupsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetChildGroupsRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
