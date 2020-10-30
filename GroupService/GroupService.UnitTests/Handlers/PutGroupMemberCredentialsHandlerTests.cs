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
        private bool _success;
        private bool _hasPermission = false;
        private CredentialVerifiedBy _credentialVerifiedBy;

        public bool RoleAssigned { get; set; }

        [SetUp]
        public void Setup()
        {
            RoleAssigned = false;
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()))
                .Returns(() => _hasPermission);

            _repository.Setup(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()))
                .Returns(() => _success);

            _repository.Setup(x => x.GetCredentialVerifiedBy(It.IsAny<int>(), It.IsAny<int>()))
                 .Returns(() => _credentialVerifiedBy);

            _classUnderTest = new PutGroupMemberCredentialsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenRequestIsValidAndAuthorisedByUserID_ReturnSuccess()
        {
            _hasPermission = true;
            _success = true;
            _credentialVerifiedBy = CredentialVerifiedBy.GroupAdmin;

            var result = _classUnderTest.Handle(new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None);

            _repository.Verify(x => x.GetCredentialVerifiedBy(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Once);
            _repository.Verify(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()), Times.Once);
            Assert.AreEqual(_success, result.Result);
        }

        [Test]
        public void WhenRequestIsForCredentialVerifiedBySystem_ThrowsException()
        {
            _hasPermission = true;
            _success = false;
            _credentialVerifiedBy = CredentialVerifiedBy.System;

            Assert.ThrowsAsync<UnauthorisedException>(() => _classUnderTest.Handle(new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None));

            _repository.Verify(x => x.GetCredentialVerifiedBy(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Never);
            _repository.Verify(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()), Times.Never);
        }

        [Test]
        public void WhenAuthorisedByUserIDIsNotAdmin_ThrowException()
        {
            _hasPermission = false;
            _success = false;
            _credentialVerifiedBy = CredentialVerifiedBy.GroupAdmin;

            Assert.ThrowsAsync<UnauthorisedException>(() => _classUnderTest.Handle(new PutGroupMemberCredentialsRequest()
            {
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None));

            _repository.Verify(x => x.GetCredentialVerifiedBy(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Once);
            _repository.Verify(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()), Times.Never);
        }

        [Test]
        public void WhenAuthorisedByUserIDEqualsUserId_ThrowException()
        {
            _hasPermission = true;
            _success = false;
            _credentialVerifiedBy = CredentialVerifiedBy.GroupAdmin;

            Assert.ThrowsAsync<UnauthorisedException>(() => _classUnderTest.Handle(new PutGroupMemberCredentialsRequest()
            {
                AuthorisedByUserID = 1,
                CredentialId = -1,
                UserId = 1,
                GroupId = -1,
                Notes = "",
                Reference = "",
                ValidUntil = DateTime.Now.AddDays(30)
            }, CancellationToken.None));

            _repository.Verify(x => x.GetCredentialVerifiedBy(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
            _repository.Verify(x => x.UserIsInRoleForGroup(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<GroupRoles>()), Times.Never);
            _repository.Verify(x => x.AddGroupMemberCredentials(It.IsAny<PutGroupMemberCredentialsRequest>()), Times.Never);
        }
    }
}