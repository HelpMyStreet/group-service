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
    public class PutGroupMemberCredentialsHandlerTests
    {
        private PutGroupMemberCredentialsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private int _groupId;
        private Dictionary<int, List<int>> _allUserRoles;
        private bool _success;
        private bool _roleAssigned;
        private bool _allowAutonomousJoinersAndLeavers;
        private bool _hasPermission = false;

        [SetUp]
        public void Setup()
        {
            _roleAssigned = false;
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()))
                .Returns(() => _hasPermission);

            _repository.Setup(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()))
                .Returns(() => _success);
             
            _classUnderTest = new PutGroupMemberCredentialsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedByUserID_ReturnSuccess()
        {
            _hasPermission = true;
            _success = true;

            var result = _classUnderTest.Handle(new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None);

            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Once);
            _repository.Verify(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()), Times.Once);
            Assert.AreEqual(_success, result.Result);
        }

        [Test]
        public void WhenAuthorisedByUserIDIsNotAdmin_ThrowException()
        {
            _hasPermission = false;
            _success = false;

            Assert.ThrowsAsync<UnauthorisedException>(() => _classUnderTest.Handle(new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None));

            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Once);
            _repository.Verify(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()), Times.Never);
        }
    }
}