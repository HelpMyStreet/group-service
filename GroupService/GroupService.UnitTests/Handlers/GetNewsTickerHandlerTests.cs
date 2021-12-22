using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.EqualityComparers;
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

    public class GetNewsTickerHandlerTests
    {
        private Mock<IRepository> _repository;
        private GetNewsTickerHandler _classUnderTest;
        private int _memberVolunteerCount;
        private Dictionary<int, int> _dictCount;


        [SetUp]
        public void Setup()
        {
            _dictCount = new Dictionary<int, int>();
            SetupRepository();
            _classUnderTest = new GetNewsTickerHandler(_repository.Object);
        }

        private void SetupRepository()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.MemberVolunterCount(It.IsAny<int?>()))
                .ReturnsAsync(() => _memberVolunteerCount);

            _repository.Setup(x => x.MemberVolunterCountLastXDays(It.IsAny<int?>(), It.IsAny<int>()))
                .ReturnsAsync((int? x, int y) => _dictCount[y] );
        }

        [TestCase(5, 10, 20, "**5** volunteers waiting to help", "**10** new volunteers joined today","", 2)]
        [TestCase(5, 1, 20, "**5** volunteers waiting to help", "", "**20** new volunteers joined this week",2)]
        [TestCase(4, 1, 20, "", "","**20** new volunteers joined this week", 1)]
        [TestCase(4, 0, 0, "", "", "", 0)]
        [Test]
        public async Task HappyPath(int volunteerCount, int lastDayCount, int last7DaysCount,
            string volunteerMessage, string lastDayMessage, string lastWeekMessage,
            int messageCount)
        {
            int? groupId = -3;
            _memberVolunteerCount = volunteerCount;
            _dictCount = new Dictionary<int, int>()
            {
                {1, lastDayCount},
                {7, last7DaysCount}
            };

            NewsTickerResponse response = await _classUnderTest.Handle(new NewsTickerRequest()
            {
                GroupId = groupId
            }, CancellationToken.None);

            if (!string.IsNullOrEmpty(volunteerMessage))
            {
                Assert.AreEqual(1, response.Messages.Count(x => x.Message == volunteerMessage));
            }

            if (!string.IsNullOrEmpty(lastDayMessage))
            {
                Assert.AreEqual(1, response.Messages.Count(x => x.Message == lastDayMessage));
            }

            if (!string.IsNullOrEmpty(lastWeekMessage))
            {
                Assert.AreEqual(1, response.Messages.Count(x => x.Message == lastWeekMessage));
            }

            Assert.AreEqual(messageCount, response.Messages.Count);
        }
    }
}