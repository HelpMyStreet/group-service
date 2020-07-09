using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
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
    public class PostAddUserToDefaultGroupsHandler : IRequestHandler<PostAddUserToDefaultGroupsRequest, PostAddUserToDefaultGroupsResponse>
    {
        private readonly IRepository _repository;
        private readonly IUserService _userService;
        private const int GROUPID_GENERIC = -1;
        private const int USERID_ADMINISTRATOR = -1;

        public PostAddUserToDefaultGroupsHandler(IRepository repository, IUserService userService)
        {
            _repository = repository;
            _userService = userService;
        }

        public async Task<PostAddUserToDefaultGroupsResponse> Handle(PostAddUserToDefaultGroupsRequest request, CancellationToken cancellationToken)
        {
            bool success = false;

            var user = _userService.GetUserByID(request.UserID).Result;
            if(user!=null)
            {
                AssignRole(GROUPID_GENERIC, request.UserID, cancellationToken);

                if (user.User.ReferringGroupId.HasValue)
                {
                    AssignRole(user.User.ReferringGroupId.Value, request.UserID, cancellationToken);
                }

                //If the List<SupportActivities> contains Face Masks, add the user to the FTLOS group
                if (user.User.SupportActivities.Contains(SupportActivities.FaceMask))
                {
                    var groupId = _repository.GetGroupByKey(new GetGroupByKeyRequest()
                    {
                        GroupKey = "ftlos"
                    }, cancellationToken);

                    AssignRole(groupId, request.UserID, cancellationToken);
                }
                success = true;
            }

            return new PostAddUserToDefaultGroupsResponse()
            {
                Success = success
            };
        }

        private async void AssignRole(int groupID, int userID, CancellationToken cancellationToken)
        {
            await _repository.AssignRoleAsync(new PostAssignRoleRequest()
            {
                GroupID = groupID,
                AuthorisedByUserID = USERID_ADMINISTRATOR,
                UserID = userID,
                Role = new RoleRequest()
                {
                    GroupRole = GroupRoles.Member
                }
            }, cancellationToken);
        }
    }
}
