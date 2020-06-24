using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class PostRevokeRoleHandler : IRequestHandler<PostRevokeRoleRequest, PostRevokeRoleResponse>
    {
        private readonly IRepository _repository;
        public PostRevokeRoleHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<PostRevokeRoleResponse> Handle(PostRevokeRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            var allroles =_repository.GetUserRoles(new GetUserRolesRequest()
            {
                UserID = request.AuthorisedByUserID.Value
            },cancellationToken);

            if (allroles != null)
            {
                var rolesForGivenGroup = allroles[request.GroupID.Value];
                if(rolesForGivenGroup!=null)
                {
                    if(rolesForGivenGroup.Contains((int)GroupRoles.Owner) && request.GroupID!=(int)GroupRoles.Owner  )
                    {
                        success = await _repository.RevokeRoleAsync(request, cancellationToken);
                    }
                    else if(rolesForGivenGroup.Contains((int)GroupRoles.UserAdmin))
                    {
                        success = await _repository.RevokeRoleAsync(request, cancellationToken);
                    }
                }
            }

            
            return new PostRevokeRoleResponse()
            {
                Outcome = success ? GroupPermissionOutcome.Success : GroupPermissionOutcome.Unauthorized
            };
        }
    }
}
