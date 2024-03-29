﻿using GroupService.Core.Domains;
using GroupService.Core.Domains.Entities;
using GroupService.Core.Dto;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.ReportService;
using HelpMyStreet.Contracts.RequestService.Response;
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
        bool AllowRoleChange(GroupRoles roleToBeAssigned, int groupId, int authorisedByUserID, CancellationToken cancellationToken);
        Task<List<UserRoleSummary>> GetTotalGroupUsersByType(IEnumerable<int> groups);
        Task<List<UserRoleSummary>> GetUserRoleSummary(IEnumerable<int> groups, GroupAction action, DateTime minDate, DateTime maxDate);
        Task<int> MemberVolunterCount(IEnumerable<int> groups);
        Task<int> MemberVolunterCountLastXDays(IEnumerable<int> groups, int days);        
        Task<bool> AddToGenericGroup(int groupId, string source);
        List<KeyValuePair<string, string>> GetGroupEmailConfiguration(int groupId, CommunicationJobTypes communicationJobType, CancellationToken cancellationToken);
        List<SupportActivityConfiguration> GetSupportActivitiesConfiguration(CancellationToken cancellationToken);
        List<SupportActivityDetail> GetSupportActivityDetails(RegistrationFormVariant registrationFormVariant, CancellationToken cancellationToken);
        GetGroupNewRequestNotificationStrategyResponse GetGroupNewRequestNotificationStrategy(int groupId, CancellationToken cancellationToken);
        Instructions GetGroupSupportActivityInstructions(int groupId, SupportActivities supportActivities, CancellationToken cancellationToken);
        double? GetGroupSupportActivityRadius(int groupId, SupportActivities supportActivities, CancellationToken cancellationToken);
        List<GroupSupportActivityRadius> GetGroupSupportActivityRadii(CancellationToken cancellationToken);
        CredentialVerifiedBy GetCredentialVerifiedBy(int groupId, int credentialId);
        List<UserInGroup> GetAllGroupMembers(int groupId);
        UserInGroup GetGroupMember(int groupId, int userId);
        GetGroupMemberDetailsResponse GetGroupMemberDetails(int groupId, int userId);
        bool AddGroupMemberCredentials(PutGroupMemberCredentialsRequest request);
        bool AddYotiVerifiedUsers(PutYotiVerifiedUserRequest request);
        List<GroupCredential> GetGroupCredentials(int groupID);
        List<List<int>> GetGroupActivityCredentialSets(int groupID, SupportActivities supportActivity);
        GetRegistrationFormVariantResponse GetRegistrationFormVariant(int groupId, string source, CancellationToken cancellationToken);
        GetRequestHelpFormVariantResponse GetRequestHelpFormVariant(int groupId, string source, CancellationToken cancellationToken);
        Group GetGroupById(int groupId, CancellationToken cancellationToken);
        List<Group> GetGroupsWithMapDetails(MapLocation mapLocation, CancellationToken cancellationToken);
        List<GroupLocation> GetGroupLocations(List<int> groups, CancellationToken cancellationToken);
        List<GroupRadius> GetMaxShiftSupportActivityRadius(List<int> groups, CancellationToken cancellationToken);
        List<Group> GetChildGroups(int groupId, CancellationToken cancellationToken);
        List<int> GetGroupAndChildGroups(int groupId, CancellationToken cancellationToken);
        Task<int> CreateGroupAsync(PostCreateGroupRequest request, CancellationToken cancellationToken);
        List<int> GetUserGroups(int userId, CancellationToken cancellationToken);
        Dictionary<int,List<int>> GetUserRoles(int userId, CancellationToken cancellationToken);
        Dictionary<int, List<int>> GetGroupMemberRoles(int groupId, CancellationToken cancellationToken);
        Task<bool> AssignRoleAsync(PostAssignRoleRequest request, CancellationToken cancellationToken);
        Task<bool> RevokeRoleAsync(PostRevokeRoleRequest request, CancellationToken cancellationToken);
        void AddUserRoleAudit(int groupId, int userId, GroupRoles groupRole, int authorisedByUserID, GroupAction groupAction, bool success, CancellationToken cancellationToken);
        bool RoleAssigned(int userId,int groupId, GroupRoles groupRole, CancellationToken cancellationToken);
        List<int> GetGroupMembers(int groupId, CancellationToken cancellationToken);
        int GetGroupByKey(GetGroupByKeyRequest request, CancellationToken cancellationToken);
        bool UserIsInRoleForGroup(int userID, int groupId, GroupRoles groupRole);
        bool UserIsInRolesForGroup(int userID, int groupId, List<GroupRoles> groupRoles, bool mustBeInAll);
        List<UserGroup> GetUsersWithRole(GroupRoles groupRoles);
        SecurityConfiguration GetSecurityConfiguration(int groupId);
        List<int> GetGroupMembersForGivenRole(int groupId, GroupRoles roles, CancellationToken cancellationToken);
        bool UserHasRolesOtherThanVolunteerAndMember(int groupId, int userId, CancellationToken cancellationToken);
    }
}