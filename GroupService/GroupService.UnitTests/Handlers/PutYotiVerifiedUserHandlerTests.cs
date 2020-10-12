using GroupService.AzureFunction;
using GroupService.Core.Exception;
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
    public class PutYotiVerifiedUserHandlerTests
    {
        private PutYotiVerifiedUserHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private bool _success;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            
            _repository.Setup(x => x.AddYotiVerifiedUsers(It.IsAny<PutYotiVerifiedUserRequest>()))
                .Returns(() => _success);
             
            _classUnderTest = new PutYotiVerifiedUserHandler(_repository.Object);
               
        }

        [Test]
        public void WhenRequestIsValid_ReturnSuccess()
        {
            _success = true;

            var result = _classUnderTest.Handle(new PutYotiVerifiedUserRequest()
            {
                UserId = 1,
                Notes = "",
                Reference = ""
            }, CancellationToken.None);

            _repository.Verify(x => x.AddYotiVerifiedUsers(It.IsAny<PutYotiVerifiedUserRequest>()), Times.Once);
            Assert.AreEqual(_success, result.Result);
        }
    }
}