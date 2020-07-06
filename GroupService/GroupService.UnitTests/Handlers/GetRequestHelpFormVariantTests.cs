using GroupService.Core.Interfaces.Repositories;
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
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetRequestHelpFormVariantTests
    {
        private GetRequestHelpFormVariantHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private GetRequestHelpFormVariantResponse _response;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns(() => _response);

            _classUnderTest = new GetRequestHelpFormVariantHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdAndSourceIsValid_ReturnReturnRequestHelpForm()
        {
            _response = new GetRequestHelpFormVariantResponse()
            {
                RequestHelpSource = RequestHelpSource.Default
            };
           

            var result = _classUnderTest.Handle(new GetRequestHelpFormVariantRequest()
            {
                GroupID = 1,
                Source = "Source"
            },CancellationToken.None).Result;

            Assert.AreEqual(_response, result);
        }

        [Test]
        public void WhenGroupIdOrSourceIsInValid_ThrowsError()
        {
            int groupId = 1;
            string source = "Source";
            _repository.Setup(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(),It.IsAny<CancellationToken>()))
                .Throws(new Exception($"GroupId {groupId} Source {source} not found in RequestHelpJourney"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetRequestHelpFormVariantRequest()
            {
                GroupID = groupId,
                Source = source
            }, CancellationToken.None));

            Assert.AreEqual($"GroupId {groupId} Source {source} not found in RequestHelpJourney", ex.Message);
        }
    }
}