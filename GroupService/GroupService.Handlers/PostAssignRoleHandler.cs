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
    public class PostAssignRoleHandler : IRequestHandler<PostAssignRoleRequest, PostAssignRoleResponse>
    {
        private readonly IRepository _repository;
        public PostAssignRoleHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<PostAssignRoleResponse> Handle(PostAssignRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            bool passedExistingRoleCheck = true;

            if (request.Role.GroupRole != GroupRoles.Member && request.Role.GroupRole != GroupRoles.Volunteer)
            {
                passedExistingRoleCheck = _repository.RoleMemberAssignedForUserInGroup(request.UserID.Value, request.GroupID.Value, cancellationToken);
            }

            bool roleAssigned = _repository.RoleAssigned(request.UserID.Value, request.GroupID.Value, request.Role.GroupRole, cancellationToken);

            if (!roleAssigned && passedExistingRoleCheck)
            {
                if (request.AuthorisedByUserID.Value == -1)
                {
                    success = await _repository.AssignRoleAsync(request, cancellationToken);
                }
                else if (request.AuthorisedByUserID.Value == request.UserID 
                            && request.Role.GroupRole == GroupRoles.Member 
                            && _repository.GetSecurityConfiguration(request.GroupID.Value).AllowAutonomousJoinersAndLeavers)
                {
                    success = await _repository.AssignRoleAsync(request, cancellationToken);
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
                                success = await _repository.AssignRoleAsync(request, cancellationToken);
                            }
                            else if (rolesForGivenGroup.Contains((int)GroupRoles.UserAdmin) && request.Role.GroupRole == GroupRoles.Member)
                            {
                                success = await _repository.AssignRoleAsync(request, cancellationToken);
                            }
                        }
                    }
                }
            }

            _repository.AddUserRoleAudit(
                       request.GroupID.Value,
                       request.UserID.Value,
                       request.Role.GroupRole,
                       request.AuthorisedByUserID.Value,
                       GroupAction.AddMember,
                       success,
                       cancellationToken
                       );

            return new PostAssignRoleResponse()
            {
                Outcome = success || roleAssigned ? GroupPermissionOutcome.Success : GroupPermissionOutcome.Unauthorized
            };
        }
    }
}
