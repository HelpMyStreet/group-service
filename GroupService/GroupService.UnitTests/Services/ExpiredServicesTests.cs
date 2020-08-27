using GroupService.Core.Domains.Entities;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using GroupService.Core.Services;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

namespace GroupService.UnitTests.Services
{
    public class ExpiredServicesTests
    {
        private ExpiredService _classUnderTest;
        private Mock<IRequestService> _requestService;
        private Mock<IRepository> _repository;
        private List<UserGroup> _userGroups;
        private bool _revoke;
        private GetJobsByFilterResponse _getJobsByFilterResponse;

        [SetUp]
        public void Setup()
        {
            SetupRepository();
            SetupRequestService();
            _classUnderTest = new ExpiredService(_requestService.Object ,_repository.Object);
               
        }

        private void SetupRepository()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetUsersWithRole(It.IsAny<GroupRoles>()))
                .Returns(() => _userGroups);

            _repository.Setup(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => _revoke);
               
        }

        private void SetupRequestService()
        {
            _requestService = new Mock<IRequestService>();

            _requestService.Setup(x => x.GetJobsByFilter(It.IsAny<GetJobsByFilterRequest>()))
                .ReturnsAsync(() => _getJobsByFilterResponse);
        }

        [Test]
        public void WhenVolunteerExpired_Revokes()
        {
            _userGroups = new List<UserGroup>()
            {
                new UserGroup(){UserID = 1, GroupID = -1}
            };

            _revoke = true;

            List<JobSummary> jobs = new List<JobSummary>()
            {
                new JobSummary()
                {
                    DateStatusLastChanged = DateTime.Now.AddDays(-35),
                    ReferringGroupID = -1
                },
                new JobSummary()
                {
                    DateStatusLastChanged = DateTime.Now.AddDays(-45),
                    ReferringGroupID = -1
                }
            };

            _getJobsByFilterResponse = new GetJobsByFilterResponse()
            {
                JobSummaries = jobs
            };


            var result = _classUnderTest.ExpireVolunteers(CancellationToken.None);
            _repository.Verify(x => x.GetUsersWithRole(It.IsAny<GroupRoles>()), Times.Once);
            _requestService.Verify(x => x.GetJobsByFilter(It.IsAny<GetJobsByFilterRequest>()), Times.Once);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(),It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public void WhenVolunteerDoesNotExpire_DoesNotRevoke()
        {
            _userGroups = new List<UserGroup>()
            {
                new UserGroup(){UserID = 1, GroupID = -1}
            };

            _revoke = true;

            List<JobSummary> jobs = new List<JobSummary>()
            {
                new JobSummary()
                {
                    DateStatusLastChanged = DateTime.Now.AddDays(-35),
                    ReferringGroupID = -1
                },
                new JobSummary()
                {
                    DateStatusLastChanged = DateTime.Now.AddDays(-10),
                    ReferringGroupID = -1
                }
            };

            _getJobsByFilterResponse = new GetJobsByFilterResponse()
            {
                JobSummaries = jobs
            };


            var result = _classUnderTest.ExpireVolunteers(CancellationToken.None);
            _repository.Verify(x => x.GetUsersWithRole(It.IsAny<GroupRoles>()), Times.Once);
            _requestService.Verify(x => x.GetJobsByFilter(It.IsAny<GetJobsByFilterRequest>()), Times.Once);
            _repository.Verify(x => x.RevokeRoleAsync(It.IsAny<PostRevokeRoleRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }
    }
}