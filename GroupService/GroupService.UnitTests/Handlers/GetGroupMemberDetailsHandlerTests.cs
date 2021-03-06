using GroupService.Core.Exception;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;

namespace GroupService.UnitTests
{
    public class GetGroupMemberDetailsHandlerTests
    {
        private GetGroupMemberDetailsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private GetGroupMemberDetailsResponse _groupMemberDetails;
        private bool _hasPermission;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupMemberDetails(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => _groupMemberDetails);

            _repository.Setup(x => x.UserIsInRolesForGroup(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<List<GroupRoles>>(),
                It.IsAny<bool>()))
                .Returns(() => _hasPermission);

            _classUnderTest = new GetGroupMemberDetailsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenUserIDAndAuthorisingUserIDAreTheSame_ReturnGroupMemberDetails()
        {
            int groupId = 1;
            int userId = 1;

            _groupMemberDetails = new GetGroupMemberDetailsResponse()
            {
                GroupRoles = new List<GroupRoles>(),
                UserCredentials = new List<UserCredential>(),
                UserRoleAudits = new List<UserRoleAudit>()
            };
            var result = _classUnderTest.Handle(new GetGroupMemberDetailsRequest()
            {
                GroupId = groupId,
                UserId = userId,
                AuthorisingUserId = userId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_groupMemberDetails.GroupRoles, result.GroupRoles);
            Assert.AreEqual(_groupMemberDetails.UserCredentials, result.UserCredentials);
            Assert.AreEqual(_groupMemberDetails.UserRoleAudits, result.UserRoleAudits);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Never);
            _repository.Verify(x => x.GetGroupMemberDetails(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenUserIDAndAuthorisingUserIDAreDifferentAndAuthorisingIsAdmin_ReturnsGroupMemberDetails()
        {
            int groupId = 1;
            int userId = 1;
            int authorisingUserId = 2;
            _hasPermission = true;

            _groupMemberDetails = new GetGroupMemberDetailsResponse()
            { 
                GroupRoles = new List<GroupRoles>(),
                UserCredentials = new List<UserCredential>(),
                UserRoleAudits = new List<UserRoleAudit>()
            };

            var result = _classUnderTest.Handle(new GetGroupMemberDetailsRequest()
            {
                GroupId = groupId,
                UserId = userId,
                AuthorisingUserId = authorisingUserId
            }, CancellationToken.None).Result;

            Assert.AreEqual(_groupMemberDetails.GroupRoles, result.GroupRoles);
            Assert.AreEqual(_groupMemberDetails.UserCredentials, result.UserCredentials);
            Assert.AreEqual(_groupMemberDetails.UserRoleAudits, result.UserRoleAudits);
            _repository.Verify(x => x.UserIsInRolesForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<List<GroupRoles>>(),It.IsAny<bool>()), Times.Once);
            _repository.Verify(x => x.GetGroupMemberDetails(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void WhenUserIDAndAuthorisingUserIDAreDifferentAndAuthorisingIsNotAdmin_ReturnsException()
        {
            int groupId = 1;
            int userId = 1;
            int authorisingUserId = 2;
            _hasPermission = false;

            Assert.ThrowsAsync<UnauthorisedException>(() => _classUnderTest.Handle(new GetGroupMemberDetailsRequest()
            {
                GroupId = groupId,
                UserId = userId,
                AuthorisingUserId = authorisingUserId
            }, CancellationToken.None));
            
            _repository.Verify(x => x.UserIsInRolesForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<List<GroupRoles>>(), It.IsAny<bool>()), Times.Once);
            _repository.Verify(x => x.GetGroupMemberDetails(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }
    }
}