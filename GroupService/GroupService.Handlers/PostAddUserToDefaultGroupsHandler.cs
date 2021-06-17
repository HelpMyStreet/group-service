using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.CommunicationService.Request;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class PostAddUserToDefaultGroupsHandler : IRequestHandler<PostAddUserToDefaultGroupsRequest, PostAddUserToDefaultGroupsResponse>
    {
        private readonly IRepository _repository;
        private readonly IUserService _userService;
        private readonly ICommunicationService _communicationService;

        private const int GROUPID_GENERIC = -1;
        private const int USERID_ADMINISTRATOR = -1;

        public PostAddUserToDefaultGroupsHandler(IRepository repository, IUserService userService, ICommunicationService communicationService)
        {
            _repository = repository;
            _userService = userService;
            _communicationService = communicationService;
        }

        public async Task<PostAddUserToDefaultGroupsResponse> Handle(PostAddUserToDefaultGroupsRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            int groupIdToBeUsedInGroupWelcomeEmail = GROUPID_GENERIC;
            var user = _userService.GetUserByID(request.UserID).Result;
            bool addToGenericGroup = true;
            if (user!=null)
            {
                bool sendGroupWelcomeEmail = false;
                if (user.User.ReferringGroupId.HasValue)
                {
                    addToGenericGroup = await _repository.AddToGenericGroup(user.User.ReferringGroupId.Value, user.User.Source);

                    success = await AssignRole(user.User.ReferringGroupId.Value, request.UserID, cancellationToken);                    
                    if (success)
                    {
                        groupIdToBeUsedInGroupWelcomeEmail = user.User.ReferringGroupId.Value;
                        sendGroupWelcomeEmail = true;
                    }
                    else
                    {
                        return new PostAddUserToDefaultGroupsResponse()
                        {
                            Success = success
                        };
                    }
                }

                if(addToGenericGroup)
                {
                    success = await AssignRole(GROUPID_GENERIC, request.UserID, cancellationToken);
                    if(!sendGroupWelcomeEmail && success)
                    {
                        sendGroupWelcomeEmail = true;
                    }
                }

                if (sendGroupWelcomeEmail)
                {
                    await _communicationService.RequestCommunication(new RequestCommunicationRequest()
                    {
                        CommunicationJob = new CommunicationJob() { CommunicationJobType = CommunicationJobTypes.GroupWelcome, },
                        GroupID = groupIdToBeUsedInGroupWelcomeEmail,
                        RecipientUserID = request.UserID
                    }, cancellationToken);
                }
            }

            return new PostAddUserToDefaultGroupsResponse()
            {
                Success = success
            };
        }

        private async Task<bool> AssignRole(int groupID, int userID, CancellationToken cancellationToken)
        {
            bool success = await _repository.AssignRoleAsync(new PostAssignRoleRequest()
            {
                GroupID = groupID,
                AuthorisedByUserID = USERID_ADMINISTRATOR,
                UserID = userID,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Member
                }
            }, cancellationToken);

            _repository.AddUserRoleAudit(
                        groupID,
                        userID,
                        GroupRoles.Member,
                        USERID_ADMINISTRATOR,
                        GroupAction.AddMember,
                        success,
                        cancellationToken
                        );
            return success;
        }
    }
}
