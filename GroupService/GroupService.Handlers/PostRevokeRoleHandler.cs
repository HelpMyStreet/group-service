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

        private void LogFailureToAssignRole(PostRevokeRoleRequest request, CancellationToken cancellationToken)
        {
            _repository.AddUserRoleAudit(
                           request.GroupID.Value,
                           request.UserID.Value,
                           request.Role.GroupRole,
                           request.AuthorisedByUserID.Value,
                           GroupAction.RevokeMember,
                           false,
                           cancellationToken
                           );
        }

        public async Task<PostRevokeRoleResponse> Handle(PostRevokeRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            bool userHasOtherRoles = false;

            if(request.Role.GroupRole == GroupRoles.Member)
            {
                userHasOtherRoles = _repository.UserHasRolesOtherThanVolunteerAndMember(request.GroupID.Value, request.UserID.Value, cancellationToken);
            }

            bool roleAssigned = _repository.RoleAssigned(request.UserID.Value, request.GroupID.Value, request.Role.GroupRole, cancellationToken);

            if (roleAssigned && !userHasOtherRoles)
            {
                bool canTryToRemoveUserFromGroup;
                if (request.AuthorisedByUserID.Value == -1)
                {
                    canTryToRemoveUserFromGroup = true;
                }
                else if (request.AuthorisedByUserID.Value == request.UserID
                            && request.Role.GroupRole == GroupRoles.Member
                            && _repository.GetSecurityConfiguration(request.GroupID.Value).AllowAutonomousJoinersAndLeavers)
                {
                    canTryToRemoveUserFromGroup = true;
                }
                else
                {
                    canTryToRemoveUserFromGroup = _repository.AllowRoleChange(request.Role.GroupRole, request.GroupID.Value, request.AuthorisedByUserID.Value, cancellationToken);  
                }

                if (canTryToRemoveUserFromGroup)
                {
                    success = await _repository.RevokeRoleAsync(request, cancellationToken);
                }
                else
                {
                    LogFailureToAssignRole(request, cancellationToken);
                }
            }
            else
            {
                LogFailureToAssignRole(request, cancellationToken);
            }

            return new PostRevokeRoleResponse()
            {
                Outcome = success || !roleAssigned ? GroupPermissionOutcome.Success : GroupPermissionOutcome.Unauthorized
            };
        }
    }
}
