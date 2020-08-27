using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Utils.Enums;
using System.Threading;
using System.Threading.Tasks;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.RequestService.Request;
using GroupService.Core.Domains.Entities;
using System.Linq;
using System;

namespace GroupService.Core.Services
{
    public class ExpiredService : IExpiredService
    {
        private readonly IRequestService _requestService;
        private readonly IRepository _repository;
        private const int ADMIN_USERID = -1;

        public ExpiredService(IRequestService requestService, IRepository repository)
        {
            _requestService = requestService;
            _repository = repository;
        }

        public async Task ExpireVolunteers(CancellationToken cancellationToken)
        {
            var userGroups = _repository.GetUsersWithRole(GroupRoles.Volunteer);

            if(userGroups != null)
            {
                foreach(UserGroup ug in userGroups)
                {
                    bool revokeRole = false;
                    var jobsAllocated = await _requestService.GetJobsByFilter(GetJobsByFilterRequestForUserID(ug.UserID,ug.GroupID));

                    if(jobsAllocated.JobSummaries.Count==0)
                    {
                        revokeRole = true;
                    }
                    else
                    {
                        var minDays = jobsAllocated.JobSummaries.Min(x => (DateTime.Now - x.DateStatusLastChanged).TotalDays);

                        if (minDays > 30)
                        {
                            revokeRole = true;
                        }
                    }
                    if(revokeRole)
                    {
                        await _repository.RevokeRoleAsync(new PostRevokeRoleRequest()
                        {
                            Role = new RoleRequest()
                            {
                                GroupRole = GroupRoles.Volunteer
                            },
                            UserID = ug.UserID,
                            GroupID = ug.GroupID,
                            AuthorisedByUserID = ADMIN_USERID
                        }, cancellationToken);
                    }
                }
            }
           
        }

        private GetJobsByFilterRequest GetJobsByFilterRequestForUserID(int userID, int referringGroupID)
        {
            return new GetJobsByFilterRequest()
            {
                ReferringGroupID = referringGroupID,
                UserID = userID
            };
        }

        
    }
}
