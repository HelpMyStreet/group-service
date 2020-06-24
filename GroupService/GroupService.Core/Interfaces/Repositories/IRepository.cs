﻿using GroupService.Core.Dto;
using HelpMyStreet.Contracts.GroupService.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Repositories
{
    public interface IRepository
    {
        Task<int> CreateGroupAsync(PostCreateGroupRequest request, CancellationToken cancellationToken);

        List<int> GetUserGroups(GetUserGroupsRequest request, CancellationToken cancellationToken);

        Dictionary<int,List<int>> GetUserRoles(GetUserRolesRequest request, CancellationToken cancellationToken);

        Task<bool> AssignRoleAsync(PostAssignRoleRequest request, CancellationToken cancellationToken);

    }
}