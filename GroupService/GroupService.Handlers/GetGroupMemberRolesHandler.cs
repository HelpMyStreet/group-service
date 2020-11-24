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
    public class GetGroupMemberRolesHandler : IRequestHandler<GetGroupMemberRolesRequest, GetGroupMemberRolesResponse>
    {
        private readonly IRepository _repository;
        private const int ADMIN_USERID = -1;
        public GetGroupMemberRolesHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMemberRolesResponse> Handle(GetGroupMemberRolesRequest request, CancellationToken cancellationToken)
        {
            bool hasPermission = true;
            GetGroupMemberRolesResponse response = null;

            if (request.UserId != ADMIN_USERID)
            {
                hasPermission = _repository.UserIsInRolesForGroup(request.UserId, request.GroupId, new List<GroupRoles>() { GroupRoles.UserAdmin, GroupRoles.UserAdmin_ReadOnly }, false);
            }

            if (hasPermission)
            {
                var roles = _repository.GetGroupMemberRoles(request.GroupId, cancellationToken);
                response = new GetGroupMemberRolesResponse()
                {
                    GroupMemberRoles = roles
                };
            }

            return response;

        }
    }
}
