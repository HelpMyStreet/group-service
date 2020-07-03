using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetNewRequestActionsHandlerTests
    {
        private GetNewRequestActionsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<int> _groups;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);

            _classUnderTest = new GetNewRequestActionsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdIsFound_ReturnGroups()
        {
            _groups = new List<int>()
            {
                1,2
            };

            var result = _classUnderTest.Handle(new GetNewRequestActionsRequest()
            {
                HelpRequest = new HelpMyStreet.Utils.Models.HelpRequest()
                {
                    ReferringGroupId = 1
                },
                NewJobsRequest = new HelpMyStreet.Contracts.RequestService.Request.NewJobsRequest()
                {
                    Jobs = new List<HelpMyStreet.Utils.Models.Job>()
                    {
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 1
                       },
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 2
                       }
                    }
                }
            }, CancellationToken.None).Result;
            Assert.AreEqual(_groups, result.Actions[1].TaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(_groups, result.Actions[2].TaskActions[NewTaskAction.NotifyMatchingVolunteers]);
        }

        [Test]
        public void WhenRequestIsDIY_ReturnsVolunteerUserID()
        {
            int volunteerUserID = 1;
            _groups = new List<int>()
            {
                volunteerUserID
            };

            var result = _classUnderTest.Handle(new GetNewRequestActionsRequest()
            {
                HelpRequest = new HelpMyStreet.Utils.Models.HelpRequest()
                {
                    Source = "DIY",
                    VolunteerUserId = volunteerUserID
                },
                NewJobsRequest = new HelpMyStreet.Contracts.RequestService.Request.NewJobsRequest()
                {
                    Jobs = new List<HelpMyStreet.Utils.Models.Job>()
                    {
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 1
                       },
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 2
                       }
                    }
                }
            }, CancellationToken.None).Result;
            Assert.AreEqual(_groups, result.Actions[1].TaskActions[NewTaskAction.AssignToVolunteer]);
        }
    }
}