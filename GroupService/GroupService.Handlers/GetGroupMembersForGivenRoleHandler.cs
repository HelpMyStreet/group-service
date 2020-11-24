using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetGroupMembersForGivenRoleHandler : IRequestHandler<GetGroupMembersForGivenRoleRequest, GetGroupMembersForGivenRoleResponse>
    {
        private readonly IRepository _repository;
        private const int ADMIN_USERID = -1;
        public GetGroupMembersForGivenRoleHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMembersForGivenRoleResponse> Handle(GetGroupMembersForGivenRoleRequest request, CancellationToken cancellationToken)
        {
            bool hasPermission = true;
            GetGroupMembersForGivenRoleResponse response = null;

            if (request.AuthorisingUserID != ADMIN_USERID)
            {
                hasPermission = _repository.UserIsInRolesForGroup(request.AuthorisingUserID, request.GroupId, new List<GroupRoles>() { GroupRoles.UserAdmin, GroupRoles.UserAdmin_ReadOnly }, false);
            }

            if (hasPermission)
            {
                var userIds = _repository.GetGroupMembersForGivenRole(request.GroupId,request.GroupRole.GroupRole, cancellationToken);
                response = new GetGroupMembersForGivenRoleResponse()
                {
                    UserIDs = userIds
                };
            }

            return response;

        }
    }
}
