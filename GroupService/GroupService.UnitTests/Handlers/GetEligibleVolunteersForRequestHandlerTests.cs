using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetEligibleVolunteersForRequestHandlerTests
    {
        private GetEligibleVolunteersForRequestHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Mock<IUserService> _userService;
        private Mock<ITargetGroupService> _targetGroupService;
        private List<VolunteerSummary> _volunteerSummaries;
        private Dictionary<int, GetGroupNewRequestNotificationStrategyResponse> _groupStrategy;
        private IEnumerable<int> _targetGroups;
        private IEnumerable<int> _groupMembers;

        [SetUp]
        public void Setup()
        {
            SetupRepository();
            SetupUserService();
            SetupTargetGroupService();
            _classUnderTest = new GetEligibleVolunteersForRequestHandler(
                _repository.Object, 
                _userService.Object,
                _targetGroupService.Object);
        }

        private void SetupRepository()
        {
            _repository = new Mock<IRepository>();

            _groupStrategy = new Dictionary<int, GetGroupNewRequestNotificationStrategyResponse>();
            _groupStrategy.Add(-1, new GetGroupNewRequestNotificationStrategyResponse()
            {
                MaxVolunteer = 2,
                NewRequestNotificationStrategy = NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                UrgentRequestNotificationStrategy = UrgentRequestNotificationStrategy.SendEmail
            });

            _groupStrategy.Add(-2, new GetGroupNewRequestNotificationStrategyResponse()
            {
                MaxVolunteer = 3,
                NewRequestNotificationStrategy = NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                UrgentRequestNotificationStrategy = UrgentRequestNotificationStrategy.SendEmail
            });

            _repository.Setup(x => x.GetGroupNewRequestNotificationStrategy(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns((int a, CancellationToken b) => _groupStrategy[a]);
        }

        private void SetupUserService()
        {
            _userService = new Mock<IUserService>();

            _userService.Setup(x => x.GetVolunteersByPostcodeAndActivity(
                It.IsAny<string>(),
                It.IsAny<List<SupportActivities>>(),
                It.IsAny<double?>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(() => _volunteerSummaries);
        }

        private void SetupTargetGroupService()
        {
            _targetGroupService = new Mock<ITargetGroupService>();
            _targetGroupService.Setup(x => x.GetTargetGroups(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _targetGroups);

            _targetGroupService.Setup(x => x.GetTargetGroupsMembers(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _groupMembers);
        }

        [TestCase(-1)]
        [TestCase(-2)]
        [Test]
        public async Task WhenEligibleVolunteersExceedMaxVolunteersSetForGroup_Then_NumberOfVolunteersWillMatchGroupSettings(int referringGroupId)
        {
            _volunteerSummaries = new List<VolunteerSummary>()
                {
                    new VolunteerSummary(){DistanceInMiles = 1.5, UserID = 1},
                    new VolunteerSummary(){DistanceInMiles = 2.5, UserID = 2},
                    new VolunteerSummary(){DistanceInMiles = 3.5, UserID = 3},
                    new VolunteerSummary(){DistanceInMiles = 4.5, UserID = 4},
                    new VolunteerSummary(){DistanceInMiles = 5.5, UserID = 5},
                    new VolunteerSummary(){DistanceInMiles = 6.5, UserID = 6}
                };

            _groupMembers = new List<int>()
            {
                1,2,3,4,5,6
            };

            var expectedResults = _volunteerSummaries
                .OrderBy(x=> x.DistanceInMiles)
                .Take(_groupStrategy[referringGroupId].MaxVolunteer);

            var request = new GetEligibleVolunteersForRequestRequest()
            {
                PostCode = "PostCode",
                ReferringGroupId = referringGroupId,
                Source = string.Empty,
                SupportActivityType = new SupportActivityType()
                {
                    SupportActivity = SupportActivities.Shopping
                }
            };
            var response = await _classUnderTest.Handle(request, CancellationToken.None);

            Assert.AreEqual(_groupStrategy[referringGroupId].MaxVolunteer, response.VolunteerSummaries.ToList().Count);
            Assert.AreEqual(expectedResults, response.VolunteerSummaries);

            int i = 1;
        }

        [TestCase(-1)]
        [TestCase(-2)]
        [Test]
        public async Task WhenInEligibleVolunteersReturned_Then_NoVolunteersReturned(int referringGroupId)
        {
            _volunteerSummaries = new List<VolunteerSummary>()
                {
                    new VolunteerSummary(){DistanceInMiles = 1.5, UserID = 11},
                    new VolunteerSummary(){DistanceInMiles = 2.5, UserID = 22},
                    new VolunteerSummary(){DistanceInMiles = 3.5, UserID = 33},
                    new VolunteerSummary(){DistanceInMiles = 4.5, UserID = 44},
                    new VolunteerSummary(){DistanceInMiles = 5.5, UserID = 55},
                    new VolunteerSummary(){DistanceInMiles = 6.5, UserID = 66}
                };

            _groupMembers = new List<int>()
            {
                1,2,3,4,5,6
            };

            var request = new GetEligibleVolunteersForRequestRequest()
            {
                PostCode = "PostCode",
                ReferringGroupId = referringGroupId,
                Source = string.Empty,
                SupportActivityType = new SupportActivityType()
                {
                    SupportActivity = SupportActivities.Shopping
                }
            };
            var response = await _classUnderTest.Handle(request, CancellationToken.None);

            Assert.AreEqual(0, response.VolunteerSummaries.ToList().Count);
        }


    }
}