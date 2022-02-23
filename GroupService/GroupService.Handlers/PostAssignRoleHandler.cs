using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.CommunicationService.Request;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
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
        private readonly ICommunicationService _communicationService;
        public PostAssignRoleHandler(IRepository repository, ICommunicationService communicationService)
        {
            _repository = repository;
            _communicationService = communicationService;
        }

        private bool PassedExistingRoleCheck(GroupRoles role, int userId, int groupId, CancellationToken cancellationToken)
        {
            bool passedExistingRoleCheck = true;
            if (role != GroupRoles.Member && role != GroupRoles.Volunteer)
            {
                //Volunteer must be a member before they can be assigned an admin role
                passedExistingRoleCheck = _repository.RoleAssigned(userId, groupId, GroupRoles.Member, cancellationToken);
            }
            return passedExistingRoleCheck;
        }

        private void LogFailureToAssignRole(PostAssignRoleRequest request, CancellationToken cancellationToken)
        {
            _repository.AddUserRoleAudit(
                           request.GroupID.Value,
                           request.UserID.Value,
                           request.Role.GroupRole,
                           request.AuthorisedByUserID.Value,
                           GroupAction.AddMember,
                           false,
                           cancellationToken
                           );
        }


        public async Task<PostAssignRoleResponse> Handle(PostAssignRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            bool roleAssigned = false;
            bool logFailure = false;

            bool passedExistingRoleCheck = PassedExistingRoleCheck(request.Role.GroupRole, request.UserID.Value, request.GroupID.Value, cancellationToken);

            if (passedExistingRoleCheck)
            {
                roleAssigned = _repository.RoleAssigned(request.UserID.Value, request.GroupID.Value, request.Role.GroupRole, cancellationToken);

                if (!roleAssigned)
                {
                    bool canTryToAddUserToGroup;
                    if (request.AuthorisedByUserID.Value == -1)
                    {
                        canTryToAddUserToGroup = true;
                    }
                    else if (request.AuthorisedByUserID.Value == request.UserID
                                && request.Role.GroupRole == GroupRoles.Member
                                && _repository.GetSecurityConfiguration(request.GroupID.Value).AllowAutonomousJoinersAndLeavers)
                    {
                        canTryToAddUserToGroup = true;
                    }
                    else
                    {
                        canTryToAddUserToGroup = _repository.AllowRoleChange(request.Role.GroupRole, request.GroupID.Value, request.AuthorisedByUserID.Value, cancellationToken);
                    }

                    if (canTryToAddUserToGroup)
                    {
                        success = await _repository.AssignRoleAsync(request, cancellationToken);
                        logFailure = !success;
                    }
                    else
                    {
                        logFailure = true;
                    }
                }
            }
            else
            {
                logFailure = true;
            }

            if(logFailure)
            {
                LogFailureToAssignRole(request, cancellationToken);
            }

            if(success && request.Role.GroupRole == GroupRoles.Member)
            {
                await _communicationService.RequestCommunication(new RequestCommunicationRequest()
                {
                    CommunicationJob = new CommunicationJob() { CommunicationJobType = CommunicationJobTypes.GroupWelcome },
                    GroupID = request.GroupID.Value,
                    RecipientUserID = request.UserID.Value
                }, cancellationToken);

                await _communicationService.RequestCommunication(new RequestCommunicationRequest()
                {
                    CommunicationJob = new CommunicationJob() { CommunicationJobType = CommunicationJobTypes.NewUserNotification },
                    GroupID = request.GroupID.Value,
                    AdditionalParameters = new System.Collections.Generic.Dictionary<string, string>()
                    {
                        { "Volunteer",request.UserID.Value.ToString() }
                    }
                }, cancellationToken);
            }

            return new PostAssignRoleResponse()
            {
                Outcome = success || roleAssigned ? GroupPermissionOutcome.Success : GroupPermissionOutcome.Unauthorized
            };
        }
    }
}
