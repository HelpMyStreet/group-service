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
            bool roleAssigned = _repository.RoleAssigned(request.UserID.Value, request.GroupID.Value, request.Role.GroupRole, cancellationToken);

            if (roleAssigned)
            {
                if (request.AuthorisedByUserID.Value == -1)
                {
                    success = await _repository.RevokeRoleAsync(request, cancellationToken);
                }
                else
                {
                    var allroles = _repository.GetUserRoles(new GetUserRolesRequest()
                    {
                        UserID = request.AuthorisedByUserID.Value
                    }, cancellationToken);

                    if (allroles != null && allroles.Count > 0)
                    {
                        var rolesForGivenGroup = allroles[request.GroupID.Value];
                        if (rolesForGivenGroup != null && rolesForGivenGroup.Count > 0)
                        {
                            if (rolesForGivenGroup.Contains((int)GroupRoles.Owner) && request.Role.GroupRole != GroupRoles.Owner)
                            {
                                success = await _repository.RevokeRoleAsync(request, cancellationToken);
                            }
                            else if (rolesForGivenGroup.Contains((int)GroupRoles.UserAdmin) && request.Role.GroupRole == GroupRoles.Member)
                            {
                                success = await _repository.RevokeRoleAsync(request, cancellationToken);
                            }
                        }
                    }   
                }
            }

            await _repository.AddUserRoleAuditAsync(
                       request.GroupID.Value,
                       request.UserID.Value,
                       request.Role.GroupRole,
                       request.AuthorisedByUserID.Value,
                       GroupAction.RevokeMember,
                       success,
                       cancellationToken
                       );

            return new PostRevokeRoleResponse()
            {
                Outcome = success || !roleAssigned ? GroupPermissionOutcome.Success : GroupPermissionOutcome.Unauthorized
            };
        }
    }
}
