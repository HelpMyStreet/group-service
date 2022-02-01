using GroupService.Core.Domains;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Services;
using HelpMyStreet.Contracts.ReportService;
using HelpMyStreet.Utils.Enums;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupService.UnitTests.Services
{
    public class ChartDataServicesTests
    {
        private Mock<IRepository> _repository;
        private List<UserRoleSummary> _userRoleSummaries;
        private ChartDataService _classUnderTest;

        [SetUp]
        public void Setup()
        {
            SetupRepository();
            _classUnderTest = new ChartDataService(_repository.Object);
        }

        private void SetupRepository()
        {
            _repository = new Mock<IRepository>();

            _userRoleSummaries = new List<UserRoleSummary>()
            {
                new UserRoleSummary() {DateRequested = new DateTime(2021,1,1), GroupAction = GroupAction.AddMember, Roles = GroupRoles.Member},
                new UserRoleSummary() {DateRequested = new DateTime(2021,1,1), GroupAction = GroupAction.AddMember, Roles = GroupRoles.Member},
                new UserRoleSummary() {DateRequested = new DateTime(2021,1,1), GroupAction = GroupAction.AddMember, Roles = GroupRoles.Owner},
                new UserRoleSummary() { DateRequested = new DateTime(2021, 1, 1), GroupAction = GroupAction.AddMember, Roles = GroupRoles.Owner},
                new UserRoleSummary() {DateRequested = new DateTime(2021,2,1), GroupAction = GroupAction.AddMember, Roles = GroupRoles.RequestSubmitter},

            };

            _repository.Setup(x => x.GetUserRoleSummary(It.IsAny<int>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .ReturnsAsync(() => _userRoleSummaries);
        }

        [Test]
        public async Task GetVolumeByUserType_Check()
        {
            DateTime minDate = new DateTime(2021, 1, 1);
            DateTime startDate = minDate;
            DateTime maxDate = new DateTime(2022, 1, 31);

            Dictionary<(string series, string xAxis), double> expectedOutcome = new Dictionary<(string xAxis, string series), double>();
            expectedOutcome.Add(("Volunteers", "2021-01"), 2);
            expectedOutcome.Add(("Admins", "2021-01"), 2);
            expectedOutcome.Add(("Admins", "2021-02"), 1);
            expectedOutcome.Add(("Volunteers", "2021-03"), 0);
            expectedOutcome.Add(("Admins", "2021-03"), 0);

            List<DataPoint> result = await _classUnderTest.GetVolumeByUserType(-1, minDate, maxDate);

            foreach (var item in expectedOutcome)
            {
                var actual = result.Where(x => x.Series == item.Key.series && x.XAxis == item.Key.xAxis).Select(x => x.Value).First();
                Assert.AreEqual(actual, item.Value);
            }
        }
    }
}
