using GroupService.Core.Dto;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Repositories
{
    public interface IRepository
    {
        GetRegistrationFormVariantResponse GetRegistrationFormVariant(int groupId, string source, CancellationToken cancellationToken);

        GetRequestHelpFormVariantResponse GetRequestHelpFormVariant(int groupId, string source, CancellationToken cancellationToken);

        Group GetGroupById(int groupId, CancellationToken cancellationToken);
        List<Group> GetChildGroups(int groupId, CancellationToken cancellationToken);

        List<int> GetGroupAndChildGroups(int groupId, CancellationToken cancellationToken);

        Task<int> CreateGroupAsync(PostCreateGroupRequest request, CancellationToken cancellationToken);

        List<int> GetUserGroups(GetUserGroupsRequest request, CancellationToken cancellationToken);

        Dictionary<int,List<int>> GetUserRoles(GetUserRolesRequest request, CancellationToken cancellationToken);

        Dictionary<int, List<int>> GetGroupMemberRoles(int groupId, CancellationToken cancellationToken);

        Task<bool> AssignRoleAsync(PostAssignRoleRequest request, CancellationToken cancellationToken);

        Task<bool> RevokeRoleAsync(PostRevokeRoleRequest request, CancellationToken cancellationToken);

        void AddUserRoleAudit(int groupId, int userId, GroupRoles groupRole, int authorisedByUserID, GroupAction groupAction, bool success, CancellationToken cancellationToken);

        bool RoleAssigned(int userId,int groupId, GroupRoles groupRole, CancellationToken cancellationToken);

        List<int> GetGroupMembers(GetGroupMembersRequest request, CancellationToken cancellationToken);

        int GetGroupByKey(GetGroupByKeyRequest request, CancellationToken cancellationToken);

        bool UserIsAdminForGroup(int userID, int groupId);
    }
}