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
    public class GetRegistrationFormVariantHandlerTests
    {
        private GetRegistrationFormVariantHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private GetRegistrationFormVariantResponse _response;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetRegistrationFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns(() => _response);

            _classUnderTest = new GetRegistrationFormVariantHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdAndSourceIsValid_ReturnRegistrationSource()
        {
            _response = new GetRegistrationFormVariantResponse()
            {
                RegistrationFormVariant = RegistrationFormVariant.Default
            };
           

            var result = _classUnderTest.Handle(new GetRegistrationFormVariantRequest()
            {
                GroupID = 1,
                Source = "Source"
            },CancellationToken.None).Result;

            Assert.AreEqual(_response, result);
        }
    }
}