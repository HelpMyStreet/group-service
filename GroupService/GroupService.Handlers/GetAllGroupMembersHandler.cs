using GroupService.Core.Exception;
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
    public class GetAllGroupMembersHandler : IRequestHandler<GetAllGroupMembersRequest, GetAllGroupMembersResponse>
    {
        private readonly IRepository _repository;
        private const int ADMIN_USERID = -1;
        public GetAllGroupMembersHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllGroupMembersResponse> Handle(GetAllGroupMembersRequest request, CancellationToken cancellationToken)
        {
            bool hasPermission = true;

            if (request.AuthorisingUserId != ADMIN_USERID)
            {
                hasPermission = _repository.UserIsInRolesForGroup(request.AuthorisingUserId, request.GroupId, new List<GroupRoles>() { GroupRoles.UserAdmin, GroupRoles.UserAdmin_ReadOnly }, false);
            }

            if (hasPermission)
            {
                var result = _repository.GetAllGroupMembers(request.GroupId);

                return new GetAllGroupMembersResponse()
                {
                    UserInGroups = result
                };
            }
            else
            {
                throw new UnauthorisedException();
            }
        }
    }
}
