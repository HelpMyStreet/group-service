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
    public class GetGroupMemberDetailsHandler : IRequestHandler<GetGroupMemberDetailsRequest, GetGroupMemberDetailsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupMemberDetailsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMemberDetailsResponse> Handle(GetGroupMemberDetailsRequest request, CancellationToken cancellationToken)
        {
            bool hasPermission = request.UserId == request.AuthorisingUserId;
            GetGroupMemberDetailsResponse response = null;

            if (!hasPermission)
            {
                hasPermission = _repository.UserIsInRolesForGroup(
                    request.AuthorisingUserId,
                    request.GroupId,
                    new List<GroupRoles>() { GroupRoles.UserAdmin, GroupRoles.UserAdmin_ReadOnly }, 
                    false);
            }

            if (hasPermission)
            {
                return _repository.GetGroupMemberDetails(request.GroupId, request.UserId);
            }
            else
            {
                throw new UnauthorisedException();
            }
        }
    }
}
