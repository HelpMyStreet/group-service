using GroupService.AzureFunction;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using GroupService.Core.Services;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using Polly.Caching;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class PostAddUserToDefaultGroupsHandlerTests
    {
        private PostAddUserToDefaultGroupsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Mock<IUserService> _userService;
        private int _groupId;
        private bool _roleAssigned = true;
        private GetUserByIDResponse _getUserByIDResponse;

        [SetUp]
        public void Setup()
        {
            SetUpUserService();
            SetUpRepository();
            _classUnderTest = new PostAddUserToDefaultGroupsHandler(_repository.Object,_userService.Object);
        }

        private void SetUpRepository()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _roleAssigned);

            _repository.Setup(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groupId);
        }

        private void SetUpUserService()
        {
            _getUserByIDResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = 1,
                    ReferringGroupId=-1,
                    SupportActivities = new List<SupportActivities>() { SupportActivities.FaceMask}
                }
            };
            _userService = new Mock<IUserService>();
            _userService.Setup(x => x.GetUserByID(It.IsAny<int>()))
                .ReturnsAsync(() => _getUserByIDResponse);
        }

        [Test]
        public void WhenUserIsFaceMaskAndReferringGroupIDIsGeneric_ReturnSuccess()
        {
            var result = _classUnderTest.Handle(new PostAddUserToDefaultGroupsRequest()
            {
                UserID = 1,
            }, CancellationToken.None);
            Assert.AreEqual(true, result.Result.Success);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Exactly(3));
            _repository.Verify(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenUserIsNotFaceMaskAndReferringGroupIDIsGeneric_ReturnSuccess()
        {
            _getUserByIDResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = 1,
                    ReferringGroupId = -1,
                    SupportActivities = new List<SupportActivities>()
                }
            };

            var result = _classUnderTest.Handle(new PostAddUserToDefaultGroupsRequest()
            {
                UserID = 1,
            }, CancellationToken.None);
            Assert.AreEqual(true, result.Result.Success);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
            _repository.Verify(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()), Times.Never);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenUserFaceMaskAndReferringGroupIDIsNotGeneric_ReturnSuccess()
        {
            _getUserByIDResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = 1,
                    ReferringGroupId = -2,
                    SupportActivities = new List<SupportActivities>() { SupportActivities.FaceMask}
                }
            };

            var result = _classUnderTest.Handle(new PostAddUserToDefaultGroupsRequest()
            {
                UserID = 1,
            }, CancellationToken.None);
            Assert.AreEqual(true, result.Result.Success);
            _repository.Verify(x => x.AssignRoleAsync(It.IsAny<PostAssignRoleRequest>(), It.IsAny<CancellationToken>()), Times.Exactly(3));
            _repository.Verify(x => x.GetGroupByKey(It.IsAny<GetGroupByKeyRequest>(), It.IsAny<CancellationToken>()), Times.Once);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
        }
    }
}