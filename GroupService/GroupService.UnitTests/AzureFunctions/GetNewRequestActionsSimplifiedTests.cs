using Castle.Core.Logging;
using GroupService.AzureFunction;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
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
    public class GetNewRequestActionsSimplifiedTests
    {
        private Mock<IMediator> _mediator;
        private Mock<ILoggerWrapper<GetNewRequestActionsSimplified>> _logger;
        private GetNewRequestActionsSimplified _classUnderTest;
        private GetNewRequestActionsSimplifiedResponse _response;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILoggerWrapper<GetNewRequestActionsSimplified>>();
            _mediator = new Mock<IMediator>();
            _mediator.Setup(x => x.Send(It.IsAny<GetNewRequestActionsSimplifiedRequest>(), It.IsAny<CancellationToken>())).ReturnsAsync(()=> _response);
            _classUnderTest = new GetNewRequestActionsSimplified(_mediator.Object,_logger.Object);

        }

        [Test]
        public async Task HappyPath_ReturnsGroup()
        {
            List<int> groups = new List<int>() { 1 };
            Dictionary<Guid, TaskAction> actions = new Dictionary<Guid, TaskAction>();
            Dictionary<NewTaskAction, List<int>> taskActions = new Dictionary<NewTaskAction, List<int>>();
            taskActions.Add(NewTaskAction.MakeAvailableToGroups, groups);

            Guid guid = Guid.NewGuid();

            actions.Add(guid, new TaskAction() { TaskActions = taskActions });
            
            _response = new GetNewRequestActionsSimplifiedResponse()
            {
                Actions = actions
            };

            IActionResult result = await _classUnderTest.Run(new GetNewRequestActionsSimplifiedRequest(),CancellationToken.None);

            OkObjectResult objectResult = result as OkObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);

            ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsTrue(deserialisedResponse.HasContent);
            Assert.IsTrue(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(0, deserialisedResponse.Errors.Count());
            Assert.AreEqual(groups, deserialisedResponse.Content.Actions[guid].TaskActions[NewTaskAction.MakeAvailableToGroups]);

            _mediator.Verify(x => x.Send(It.IsAny<GetNewRequestActionsSimplifiedRequest>(), It.IsAny<CancellationToken>()),Times.Once);
        }

        [Test]
        public async Task SadPath_ReturnsError()
        {
            int groupId = (int)Groups.Generic;
            string source = string.Empty;
            SupportActivities activity = SupportActivities.Shopping;

            GetNewRequestActionsSimplifiedRequest req = new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = source,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    {
                        activity
                    }
                }
            };

            _mediator.Setup(x => x.Send(It.IsAny<GetNewRequestActionsSimplifiedRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception($"MakeAvailableToGroups missing for groupId:{groupId} and " +
                   $"source:{source} and " +
                   $"supportActivity:{activity.FriendlyNameShort()}"));

            IActionResult result = await _classUnderTest.Run(req, CancellationToken.None);
            ObjectResult objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode> deserialisedResponse = objectResult.Value as ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode>;
            Assert.IsNotNull(deserialisedResponse);

            Assert.IsFalse(deserialisedResponse.IsSuccessful);
            Assert.AreEqual(1, deserialisedResponse.Errors.Count());
            Assert.AreEqual(GroupServiceErrorCode.InternalServerError, deserialisedResponse.Errors[0].ErrorCode);

            _mediator.Verify(x => x.Send(It.IsAny<GetNewRequestActionsSimplifiedRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
