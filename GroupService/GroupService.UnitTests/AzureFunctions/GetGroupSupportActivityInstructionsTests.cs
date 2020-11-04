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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests.AzureFunctions
{
    public class GetGroupSupportActivityInstructionsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetGroupSupportActivityInstructionsRequest>> _logger;
        private GetGroupSupportActivityInstructions _classUnderTest;
        private GetGroupSupportActivityInstructionsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetGroupSupportActivityInstructionsRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetGroupSupportActivityInstructionsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetGroupSupportActivityInstructions(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsInstructions()
        {
            int groupId = 1;
            SupportActivities supportActivity = SupportActivities.Shopping;

            _response = new GetGroupSupportActivityInstructionsResponse()
            {
                Instructions = new HelpMyStreet.Utils.Models.Instructions()
                {
                    SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_Shopping,
                    Intro = "INTRO",
                    Steps = new List<HelpMyStreet.Utils.Models.Step>()
                    {
                        new HelpMyStreet.Utils.Models.Step()
                        {
                            Heading = "Heading",
                            Detail = "Detail"
                        }
                    },
                    Close = "CLOSE"
                }
            };

            IActionResult result = await _classUnderTest.Run(new GetGroupSupportActivityInstructionsRequest()
            {
                GroupId = groupId,
                SupportActivityType = new SupportActivityType() { SupportActivity = supportActivity}
            },CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetGroupSupportActivityInstructionsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupSupportActivityInstructionsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(_response.Instructions, deserialisedResponse.Content.Instructions);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupSupportActivityInstructionsRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task InvalidGroupSupportActivity_ThrowsInternalServerError()
        {
            int groupId = -8;
            SupportActivities activity = SupportActivities.Shopping;
            GetGroupSupportActivityInstructionsRequest req = new GetGroupSupportActivityInstructionsRequest();

            _mediator.Setup(x => x.Send(It.IsAny<GetGroupSupportActivityInstructionsRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception($"Unable to find support activity instructions for GroupId={groupId} and SupportActivity={activity}"));



            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);

            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            ResponseWrapper<GetGroupSupportActivityInstructionsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetGroupSupportActivityInstructionsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.HasContent);
            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.InternalServerError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetGroupSupportActivityInstructionsRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

    }
}
