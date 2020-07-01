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
    public class PostCreateGroupHandlerTests
    {
        private PostCreateGroupHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private int _groupId;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.CreateGroupAsync(It.IsAny<PostCreateGroupRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _groupId);

            _classUnderTest = new PostCreateGroupHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupNameIsValid_ReturnGroupId()
        {
            _groupId = 1;
            var result = _classUnderTest.Handle(new PostCreateGroupRequest()
            {
                GroupName = "Group"
            },CancellationToken.None).Result;

            Assert.AreEqual(1, result.GroupId);
        }

        [Test]
        public void WhenGroupNameIsInValid_ThrowsError()
        {
            string groupName = "Group";
            string groupKey = "GroupKey";
            _repository.Setup(x => x.CreateGroupAsync(It.IsAny<PostCreateGroupRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception($"GroupName {groupName} or GroupKey {groupKey} already exists as a group"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new PostCreateGroupRequest()
            {
                GroupName = groupName
            }, CancellationToken.None));

            Assert.AreEqual($"GroupName {groupName} or GroupKey {groupKey} already exists as a group", ex.Message);
        }

        [Test]
        public void WhenParentGroupNameIsInValid_ThrowsError()
        {
            string groupName = "Group";
            string parentGroupName = "ParentGroup";
            _repository.Setup(x => x.CreateGroupAsync(It.IsAny<PostCreateGroupRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception($"{parentGroupName} does not exists as a group and cannot therefore be linked as a parent group"));

            Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new PostCreateGroupRequest()
            {
                GroupName = groupName,
                ParentGroupName = parentGroupName
            }, CancellationToken.None));

            Assert.AreEqual($"{parentGroupName} does not exists as a group and cannot therefore be linked as a parent group", ex.Message);
        }
    }
}