using Castle.Core.Logging;
using GroupService.AzureFunction;
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
    public class GetRegistrationFormVariantTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetRegistrationFormVariant>> _logger;
        private GetRegistrationFormVariant _classUnderTest;
        private GetRegistrationFormVariantResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetRegistrationFormVariant>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetRegistrationFormVariantRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetRegistrationFormVariant(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsRegistrationForm()
        {
            RegistrationFormVariant registrationFormVariant = RegistrationFormVariant.Default;

            _response = new GetRegistrationFormVariantResponse()
            {
               RegistrationFormVariant = registrationFormVariant
            };

            IActionResult result = await _classUnderTest.Run(new GetRegistrationFormVariantRequest()
            {
                GroupID = 1,
                Source = "Source"
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(registrationFormVariant, deserialisedResponse.Content.RegistrationFormVariant);

            _mediator.Verify(x => x.Send(It.IsAny<GetRegistrationFormVariantRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task MissingParameters_ThrowsValidationError()
        {
            GetRegistrationFormVariantRequest req = new GetRegistrationFormVariantRequest();

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(422, objectResult.StatusCode);

            ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.ValidationError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetRegistrationFormVariantRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

    }
}
