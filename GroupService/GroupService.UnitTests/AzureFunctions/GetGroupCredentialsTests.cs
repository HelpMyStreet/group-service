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
    public class GetGroupCredentialsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupCredentialsRequest>> _logger;
        private GetGroupCredentials _classUnderTest;
        private GetGroupCredentialsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupCredentialsRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupCredentialsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => _response);
            _classUnderTest = new GetGroupCredentials(_mediator.Object, _logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroupCredentials()
        {
            List<GroupCredential> groupCredentials = new List<GroupCredential>();
            groupCredentials.Add(new GroupCredential()
            {
                CredentialID = 1,
                GroupID = 1
            });

            _response = new GetGroupCredentialsResponse()
            {
               GroupCredentials = groupCredentials
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupCredentialsRequest()
            {
                GroupID = 1
            }, CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupCredentialsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupCredentialsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(groupCredentials.Count, deserialisedResponse.Content.GroupCredentials.Count());
            Assert.AreEqual(groupCredentials, deserialisedResponse.Content.GroupCredentials);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupCredentialsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
