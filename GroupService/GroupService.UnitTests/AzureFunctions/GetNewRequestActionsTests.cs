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
    public class GetNewRequestActionsTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetNewRequestActionsRequest>> _logger;
        private GetNewRequestActions _classUnderTest;
        private GetNewRequestActionsResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetNewRequestActionsRequest>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetNewRequestActionsRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetNewRequestActions(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroup()
        {
            List<int> groups = new List<int>() { 1 };
            Dictionary<int, TaskAction> actions = new Dictionary<int, TaskAction>();
            Dictionary<NewTaskAction, List<int>> taskActions = new Dictionary<NewTaskAction, List<int>>();
            taskActions.Add(NewTaskAction.MakeAvailableToGroups, groups);

            actions.Add(1, new TaskAction() { TaskActions = taskActions });
            
            _response = new GetNewRequestActionsResponse()
            {
                Actions = actions
            };

            IActionResult result = await _classUnderTest.Run(new GetNewRequestActionsRequest(),CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetNewRequestActionsResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetNewRequestActionsResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(groups, deserialisedResponse.Content.Actions[1].TaskActions[NewTaskAction.MakeAvailableToGroups]);

            _mediator.Verify(x => x.Send(It.IsAny<GetNewRequestActionsRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }
    }
}
