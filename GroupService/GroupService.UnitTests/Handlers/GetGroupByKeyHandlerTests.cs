using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetGroupByKeyHandlerTests
    {
        private GetGroupByKeyHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private int _groupId;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groupId);

            _classUnderTest = new GetGroupByKeyHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupKeyIsValid_ReturnGroupId()
        {
            _groupId = 1;
            var result = _classUnderTest.Handle(new GetGroupByKeyRequest()
            {
                GroupKey = "Key"
            },CancellationToken.None).Result;

            Assert.AreEqual(1, result.GroupId);
        }

        [Test]
        public void WhenGroupKeyIsInValid_ThrowsError()
        {
            string groupKey = "GroupKey";
            _repository.Setup(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()))
                .Throws(new Exception($"{groupKey} not found"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetGroupByKeyRequest()
            {
                GroupKey = groupKey
            }, CancellationToken.None));

            Assert.AreEqual($"{groupKey} not found", ex.Message);
        }
    }
}