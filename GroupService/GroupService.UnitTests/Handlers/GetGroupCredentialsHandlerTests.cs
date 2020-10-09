using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;

namespace GroupService.UnitTests
{
    public class GetGroupCredentialsHandlerTests
    {
        private GetGroupCredentialsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<GroupCredential> _groupCredentials;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupCredentials(It.IsAny<int>()))
                .Returns(() => _groupCredentials);

            _classUnderTest = new GetGroupCredentialsHandler(_repository.Object);
               
        }

        [Test]
        public void HappyReturns_ReturnGroupCredentials()
        {
            int groupId = 1;

            _groupCredentials = new List<GroupCredential>();
            _groupCredentials.Add(new GroupCredential()
            {
                GroupID = groupId,
                CredentialID = 1
            });

            _groupCredentials.Add(new GroupCredential()
            {
                GroupID = groupId,
                CredentialID = 2
            });

            var result = _classUnderTest.Handle(new GetGroupCredentialsRequest()
            {
                GroupID = groupId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_groupCredentials, result.GroupCredentials);
            _repository.Verify(x => x.GetGroupCredentials(It.IsAny<int>()), Times.Once);
        }
    }
}