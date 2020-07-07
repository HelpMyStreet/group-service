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
        private int _getGroupByKeyResponse;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);
            _repository.Setup(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() => _getGroupByKeyResponse);

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
            Assert.AreEqual(2, result.Actions.Count);
            Assert.AreEqual(2, result.Actions[1].TaskActions.Count);
            Assert.AreEqual(2, result.Actions[2].TaskActions.Count);
            Assert.AreEqual(_groups, result.Actions[1].TaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(_groups, result.Actions[2].TaskActions[NewTaskAction.NotifyMatchingVolunteers]);
        }

        [Test]
        public void WhenTaskIsFaceCovering_CallsGetGroupByKey()
        {
            _groups = new List<int>()
            {
                1,2
            };

            _getGroupByKeyResponse = 8;

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
                           JobID = 1,
                           SupportActivity = SupportActivities.FaceMask
                       },
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 2,
                           SupportActivity = SupportActivities.FaceMask
                       },
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 3,
                           SupportActivity = SupportActivities.DogWalking
                       }
                    }
                }
            }, CancellationToken.None).Result;
            _repository.Verify(m => m.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
            Assert.AreEqual(3, result.Actions.Count);
            Assert.AreEqual(2, result.Actions[1].TaskActions.Count);
        }

        [Test]
        public void WhenRequestIsDIY_ReturnsVolunteerUserID()
        {
            int volunteerUserID = 11;
            _groups = new List<int>()
            {
                1,2
            };

            var result = _classUnderTest.Handle(new GetNewRequestActionsRequest()
            {
                HelpRequest = new HelpMyStreet.Utils.Models.HelpRequest()
                {
                    Source = "DIY",
                    ReferringGroupId = 1,
                    VolunteerUserId = volunteerUserID
                },
                NewJobsRequest = new HelpMyStreet.Contracts.RequestService.Request.NewJobsRequest()
                {
                    Jobs = new List<HelpMyStreet.Utils.Models.Job>()
                    {
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 1,
                           Questions = new List<HelpMyStreet.Utils.Models.Question>(){new HelpMyStreet.Utils.Models.Question() { Id = (int)Questions.WillYouCompleteYourself, Answer = "true"} }
                       },
                       new HelpMyStreet.Utils.Models.Job()
                       {
                           JobID = 2,
                           Questions = new List<HelpMyStreet.Utils.Models.Question>(){new HelpMyStreet.Utils.Models.Question() { Id = (int)Questions.WillYouCompleteYourself, Answer = "true"} }
                       }
                    }
                }
            }, CancellationToken.None).Result;
            Assert.AreEqual(2, result.Actions.Count);
            Assert.AreEqual(2, result.Actions[1].TaskActions.Count);
            Assert.AreEqual(new List<int>() { volunteerUserID }, result.Actions[1].TaskActions[NewTaskAction.AssignToVolunteer]);
            Assert.AreEqual(_groups, result.Actions[1].TaskActions[NewTaskAction.MakeAvailableToGroups]);
        }
    }
}