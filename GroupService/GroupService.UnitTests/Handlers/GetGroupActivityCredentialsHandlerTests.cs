using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

namespace GroupService.UnitTests
{
    public class GetGroupActivityCredentialsHandlerTests
    {
        private GetGroupActivityCredentialsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<List<int>> _credentialSets;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupActivityCredentialSets(It.IsAny<int>(), It.IsAny<SupportActivities>()))
                .Returns(() => _credentialSets);

            _classUnderTest = new GetGroupActivityCredentialsHandler(_repository.Object);
               
        }

        [Test]
        public void HappyReturns_ReturnGroupCredentialSets()
        {
            int groupId = 1;
            SupportActivities activity = SupportActivities.Shopping;

            _credentialSets = new List<List<int>>();
            _credentialSets.Add(new List<int>()
            {
                1
            });
            _credentialSets.Add(new List<int>()
            {
                2
            });

            var result = _classUnderTest.Handle(new GetGroupActivityCredentialsRequest()
            {
                GroupId = groupId,
                SupportActivityType = new SupportActivityType() {SupportActivity = activity}
            }, CancellationToken.None).Result;

            Assert.AreEqual(_credentialSets, result.CredentialSets);
            _repository.Verify(x => x.GetGroupActivityCredentialSets(It.IsAny<int>(), It.IsAny<SupportActivities>()), Times.Once);
        }

        [Test]
        public void UnHappyPath_ThrowsException()
        {
            int groupId = 1;
            SupportActivities activity = SupportActivities.Shopping;

            _credentialSets = null;

            Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetGroupActivityCredentialsRequest()
            {
                GroupId = groupId,
                SupportActivityType = new SupportActivityType() { SupportActivity = activity }
            }, CancellationToken.None));
            _repository.Verify(x => x.GetGroupActivityCredentialSets(It.IsAny<int>(), It.IsAny<SupportActivities>()), Times.Once);
        }
    }
}