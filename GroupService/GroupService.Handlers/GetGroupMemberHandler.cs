﻿using GroupService.Core.Exception;
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
    public class GetGroupMemberHandler : IRequestHandler<GetGroupMemberRequest, GetGroupMemberResponse>
    {
        private readonly IRepository _repository;
        public GetGroupMemberHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMemberResponse> Handle(GetGroupMemberRequest request, CancellationToken cancellationToken)
        {
            bool hasPermission = request.UserId == request.AuthorisingUserId;
            GetGroupMemberResponse response = null;

            if(!hasPermission)
            {
                hasPermission = _repository.UserIsInRolesForGroup(
                    request.AuthorisingUserId,
                    request.GroupId,
                    new List<GroupRoles>() { GroupRoles.TaskAdmin, GroupRoles.UserAdmin, GroupRoles.UserAdmin_ReadOnly }, 
                    false);
            }    

            if (hasPermission)
            {
                var result = _repository.GetGroupMember(request.GroupId, request.UserId);
                response = new GetGroupMemberResponse()
                {
                    UserInGroup = result
                };
            }
            else
            {
                throw new UnauthorisedException();
            }
            return response;
        }
    }
}
