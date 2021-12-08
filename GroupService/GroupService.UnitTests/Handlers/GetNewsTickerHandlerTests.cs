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
        private int _memberVolunterCountLastXDays;
        private IEqualityComparer<NewsTickerMessage> _equalityComparer;
        private Dictionary<int, int> _dictCount;


        [SetUp]
        public void Setup()
        {
            _dictCount = new Dictionary<int, int>();
            SetupRepository();
            _equalityComparer = new NewsTickerMessages_EqualityComparer();
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

        [TestCase(5, 10, 20, 2)]
        [TestCase(5, 1, 20, 2)]
        [TestCase(4, 1, 20, 1)]
        [TestCase(4, 0, 0, 0)]
        [Test]
        public async Task HappyPath(int volunteerCount, int lastDayCount, int last7DaysCount, int messageCount)
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

            if (volunteerCount >= 5)
            {
                Assert.AreEqual(true, response.Messages.Contains(new NewsTickerMessage()
                {
                    Value = volunteerCount,
                    Message = $"**{ volunteerCount }** volunteers waiting to help"
                }, _equalityComparer));
            }

            if (lastDayCount >= 5)
            {
                Assert.AreEqual(true, response.Messages.Contains(new NewsTickerMessage()
                {
                    Value = lastDayCount,
                    Message = $"**{ lastDayCount }** new volunteers joined today"
                }, _equalityComparer));
            }

            if (last7DaysCount >= 2 && lastDayCount <= 1)
            {
                Assert.AreEqual(true, response.Messages.Contains(new NewsTickerMessage()
                {
                    Value = last7DaysCount,
                    Message = $"**{ last7DaysCount }** new volunteers joined this week"
                }, _equalityComparer));
            }

            Assert.AreEqual(messageCount, response.Messages.Count);
        }
    }
}