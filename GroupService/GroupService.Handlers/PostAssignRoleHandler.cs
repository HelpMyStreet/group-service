﻿using GroupService.Core.Interfaces.Repositories;
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

            bool roleExists = _repository.RoleExists(request.UserID.Value, request.GroupID.Value, request.Role.GroupRole, cancellationToken);

            if (!roleExists)
            {
                if (request.AuthorisedByUserID.Value == -1)
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
                            if (rolesForGivenGroup.Contains((int)GroupRoles.Owner) && request.GroupID != (int)GroupRoles.Owner)
                            {
                                success = await _repository.AssignRoleAsync(request, cancellationToken);
                            }
                            else if (rolesForGivenGroup.Contains((int)GroupRoles.UserAdmin))
                            {
                                success = await _repository.AssignRoleAsync(request, cancellationToken);
                            }
                        }
                    }
                }
            }

            await _repository.AddUserRoleAuditAsync(
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
                Outcome = success ? GroupPermissionOutcome.Success : GroupPermissionOutcome.Unauthorized
            };
        }
    }
}
