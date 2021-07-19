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
    public class PostAddUserToDefaultGroupsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<PostAddUserToDefaultGroups>> _logger;
        private PostAddUserToDefaultGroups _classUnderTest;
        private PostAddUserToDefaultGroupsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<PostAddUserToDefaultGroups>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<PostAddUserToDefaultGroupsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new PostAddUserToDefaultGroups(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsSuccess()
        {
            _response = new PostAddUserToDefaultGroupsResponse()
            {
                Success = true
            };

            IActionResult result = await _classUnderTest.Run(new PostAddUserToDefaultGroupsRequest()
            {
                UserID = 1
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<PostAddUserToDefaultGroupsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<PostAddUserToDefaultGroupsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(true, deserialisedResponse.Content.Success);

            _mediator.Verify(x => x.Send(It.IsAny<PostAddUserToDefaultGroupsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
