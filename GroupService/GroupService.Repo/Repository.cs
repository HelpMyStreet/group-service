using AutoMapper;
using GroupService.Core.Domains;
using GroupService.Core.Domains.Entities;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
using HelpMyStreet.Utils.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace GroupService.Repo
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public Repository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AssignRoleAsync(PostAssignRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;

            var group = _context.Group.FirstOrDefault(w => w.Id == request.GroupID);

            if (group == null)
                return false;

            var userRole = _context.UserRole.FirstOrDefault(x => x.GroupId == request.GroupID.Value
                 && x.UserId == request.UserID.Value
                 && x.RoleId == (int)request.Role.GroupRole);

            if (userRole == null)
            {
                _context.UserRole.Add(new UserRole()
                {
                    GroupId = request.GroupID.Value,
                    UserId = request.UserID.Value,
                    RoleId = (int)request.Role.GroupRole
                });

                _context.UserRoleAudit.Add(new EntityFramework.Entities.UserRoleAudit()
                {
                    DateRequested = DateTime.Now.ToUniversalTime(),
                    GroupId = request.GroupID.Value,
                    UserId = request.UserID.Value,
                    RoleId = (int)request.Role.GroupRole,
                    AuthorisedByUserId = request.AuthorisedByUserID.Value,
                    ActionId = (byte) GroupAction.AddMember,
                    Success = true
                });

                int result = _context.SaveChanges();
                if (result == 2)
                {
                    success = true;
                }
            }
            
            return success;
        }
        public async Task<int> CreateGroupAsync(PostCreateGroupRequest request, CancellationToken cancellationToken)
        {
            int? parentGroupId = null;
            
            var group = _context.Group.FirstOrDefault(x => x.GroupName == request.GroupName && x.GroupKey == request.GroupKey);

            if (group != null)
            {
                throw new Exception($"GroupName {request.GroupName} or GroupKey {request.GroupKey} already exists as a group");
            }

            EntityFramework.Entities.Group parentGroup = null;

            if(request.ParentGroupName!=null)
            {
                parentGroup = _context.Group.FirstOrDefault(x => x.GroupName == request.ParentGroupName);
                if (parentGroup == null)
                {
                    throw new Exception($"{request.ParentGroupName} does not exists as a group and cannot therefore be linked as a parent group");
                }
                parentGroupId = parentGroup.Id;
            }

            EntityFramework.Entities.Group g = new EntityFramework.Entities.Group()
            {
                GroupName = request.GroupName,
                GroupKey = request.GroupKey,
                ParentGroupId = parentGroupId
            };
            _context.Group.Add(g);
            await _context.SaveChangesAsync(cancellationToken);
            return g.Id;         
        }

        public List<int> GetUserGroups(int userId, CancellationToken cancellationToken)
        {
            return _context.UserRole
                .Where(w => w.UserId == userId && w.RoleId == (int)GroupRoles.Member)
                .Select(s => s.GroupId)
                .ToList();
        }

        public Dictionary<int, List<int>> GetUserRoles(int userId, CancellationToken cancellationToken)
        {
            Dictionary<int, List<int>> response = new Dictionary<int, List<int>>();

            var roles = _context.UserRole
                .Where(w => w.UserId == userId).ToList();

            List<int> distinctGroups = roles
                .Select(r => r.GroupId)
                .Distinct()
                .ToList();

            foreach (int i in distinctGroups)
            {
                response.Add(i, roles.Where(w => w.GroupId == i).Select(x=>x.RoleId).ToList());
            }
            return response;
        }

        public Dictionary<int, List<int>> GetGroupMemberRoles(int groupId, CancellationToken cancellationToken)
        {
            Dictionary<int, List<int>> response = new Dictionary<int, List<int>>();

            var roles = _context.UserRole
                .Where(w => w.GroupId == groupId).ToList();

            List<int> distinctUsers = roles
                .Select(r => r.UserId)
                .Distinct()
                .ToList();

            foreach (int i in distinctUsers)
            {
                response.Add(i, roles.Where(w => w.UserId == i).Select(x => x.RoleId).ToList());
            }

            return response;
        }

        public async Task<bool> RevokeRoleAsync(PostRevokeRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            
            _context.UserRole.Remove(_context.UserRole.First(
            w => w.UserId == request.UserID.Value &&
            w.GroupId == request.GroupID.Value &&
            w.RoleId == (int)request.Role.GroupRole));

            _context.UserRoleAudit.Add(new EntityFramework.Entities.UserRoleAudit()
            {
                DateRequested = DateTime.Now.ToUniversalTime(),
                GroupId = request.GroupID.Value,
                UserId = request.UserID.Value,
                RoleId = (int)request.Role.GroupRole,
                AuthorisedByUserId = request.AuthorisedByUserID.Value,
                ActionId = (byte)GroupAction.RevokeMember,
                Success = true
            });

            int result = await _context.SaveChangesAsync(cancellationToken);
            if (result == 2)
            {
                success = true;
            }
            return success;
        }

        public void AddUserRoleAudit(int groupId, int userId, GroupRoles groupRole, int authorisedByUserID, GroupAction groupAction, bool success, CancellationToken cancellationToken)
        {
            _context.UserRoleAudit.Add(new EntityFramework.Entities.UserRoleAudit()
            {
                DateRequested = DateTime.Now.ToUniversalTime(),
                GroupId = groupId,
                UserId = userId,
                RoleId = (int)groupRole,
                AuthorisedByUserId = authorisedByUserID,
                ActionId = (byte) groupAction,
                Success = success
            });
            _context.SaveChanges();
        }

        public bool RoleAssigned(int userId, int groupId, GroupRoles groupRole, CancellationToken cancellationToken)
        {
            UserRole role = _context.UserRole.FirstOrDefault(
                w => w.UserId == userId &&
                w.GroupId == groupId &&
                w.RoleId == (int)groupRole
                );

            if(role!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> GetGroupMembers(int groupId, CancellationToken cancellationToken)
        {
            return _context.UserRole
                .Where(w => w.GroupId == groupId && w.RoleId == (int) GroupRoles.Member)
                .Select(s => s.UserId)
                .ToList();
        }

        public int GetGroupByKey(GetGroupByKeyRequest request, CancellationToken cancellationToken)
        {
            var group = _context.Group.FirstOrDefault(w => w.GroupKey == request.GroupKey);
            if (group != null)
            {
                return group.Id;
            }
            else
            {
                throw new Exception($"{request.GroupKey} not found");
            }
        }

        public List<int> GetGroupAndChildGroups(int groupId, CancellationToken cancellationToken)
        {
            return _context.Group.Where(x => x.Id == groupId || x.ParentGroupId == groupId)
                .Select(x=>x.Id)
                .ToList();
        }

        public HelpMyStreet.Utils.Models.Group GetGroupById(int groupId, CancellationToken cancellationToken)
        {
            var group = _context.Group
                .Include(x=> x.GroupMapDetails)
                .FirstOrDefault(x => x.Id == groupId);

            if (group != null)
            {
                return _mapper.Map<HelpMyStreet.Utils.Models.Group>(group);
            }
            else
            {
                throw new Exception($"{groupId} not found");
            }
        }

        public List<HelpMyStreet.Utils.Models.Group> GetChildGroups(int groupId, CancellationToken cancellationToken)
        {
            var groups = _context.Group.Where(x => x.ParentGroupId == groupId);

            if (groups != null)
            {
                return groups.Select(x => _mapper.Map<HelpMyStreet.Utils.Models.Group>(x)).ToList();
            }
            else
            {
                throw new Exception($"{groupId} not found");
            }
        }

        public GetRegistrationFormVariantResponse GetRegistrationFormVariant(int groupId, string source, CancellationToken cancellationToken)
        {
            if (source == null)
            {
                source = string.Empty;
            }
            var registrationForm = _context.RegistrationJourney.FirstOrDefault(x => x.GroupId == groupId && x.Source == source);

            if(registrationForm!=null)
            {
                return new GetRegistrationFormVariantResponse()
                {
                    RegistrationFormVariant = (RegistrationFormVariant)registrationForm.RegistrationFormVariant
                };
            }
            else
            {
                //check for a registration form without looking at the source
                registrationForm = _context.RegistrationJourney.FirstOrDefault(x => x.GroupId == groupId && x.Source == string.Empty);
                if (registrationForm != null)
                {
                    return new GetRegistrationFormVariantResponse()
                    {
                        RegistrationFormVariant = (RegistrationFormVariant)registrationForm.RegistrationFormVariant
                    };
                }
                else
                {
                    //use generic group
                    return new GetRegistrationFormVariantResponse()
                    {
                        RegistrationFormVariant = RegistrationFormVariant.Default
                    };
                }
            }
        }

        public GetRequestHelpFormVariantResponse GetRequestHelpFormVariant(int groupId, string source, CancellationToken cancellationToken)
        {
            var requestHelpJourney = _context.RequestHelpJourney
                                        .Include(x=> x.Group)
                                        .ThenInclude(x=> x.RequestorDetails)
                                        .FirstOrDefault(x => x.GroupId == groupId && x.Source == (source ?? string.Empty));

            if (requestHelpJourney == null)
            {
                // Try default source
                requestHelpJourney = _context.RequestHelpJourney.FirstOrDefault(x => x.GroupId == groupId && x.Source == string.Empty);
            }

            if (requestHelpJourney == null)
            {
                throw new Exception($"GroupId {groupId} Source {source} not found in RequestHelpJourney");
            }

            GetRequestHelpFormVariantResponse result = new GetRequestHelpFormVariantResponse()
            {
                RequestHelpFormVariant = (RequestHelpFormVariant)requestHelpJourney.RequestHelpFormVariant,
                TargetGroups = (TargetGroups)requestHelpJourney.TargetGroups,
                RequestorDefinedByGroup = requestHelpJourney.RequestorDefinedByGroup,
                AccessRestrictedByRole = requestHelpJourney.AccessRestrictedByRole,
                RequestsRequireApproval = requestHelpJourney.RequestsRequireApproval,
                SuppressRecipientPersonalDetails = requestHelpJourney.SuppressRecipientPersonalDetails
            };

            if(requestHelpJourney.RequestorDefinedByGroup == true && requestHelpJourney.Group?.RequestorDetails!=null)
            {
                RequestorDetails details = requestHelpJourney.Group.RequestorDetails;
                result.RequestorPersonalDetails = new RequestPersonalDetails()
                {
                    FirstName = details.FirstName,
                    LastName = details.LastName,
                    OtherNumber = details.OtherPhone,
                    MobileNumber = details.MobilePhone,
                    EmailAddress = details.EmailAddress,
                    Address = new Address()
                    {
                        AddressLine1 = details.AddressLine1,
                        AddressLine2 = details.AddressLine2,
                        AddressLine3 = details.AddressLine3,
                        Locality = details.Locality,
                        Postcode = details.Postcode
                    }
                };
            }

            return result;
        }

        public bool UserIsInRoleForGroup(int userID, int groupId, GroupRoles groupRole)
        {
            bool isAdmin = false;

            var role = _context.UserRole.FirstOrDefault(
                x => x.RoleId == (int) groupRole && 
                x.GroupId == groupId && 
                x.UserId == userID);
            
            if(role!=null)
            {
                isAdmin = true;
            }

            return isAdmin;
        }

        public bool UserIsInRolesForGroup(int userID, int groupId, List<GroupRoles> groupRoles, bool mustBeInAll)
        {

            var roles = groupRoles.Where(groupRole => _context.UserRole.FirstOrDefault(
                x => x.RoleId == (int)groupRole &&
                x.GroupId == groupId &&
                x.UserId == userID) != null);

            bool isAdmin = mustBeInAll ? roles.Count() == groupRoles.Count() : roles.Count() > 0;   

            return isAdmin;
        }

        public List<UserGroup> GetUsersWithRole(GroupRoles groupRoles)
        {
            return _context.UserRole.Where(x => x.RoleId == (int) groupRoles)
                .Select(s=> new UserGroup()
                {
                    GroupID = s.GroupId,
                    UserID = s.UserId
                }).ToList();        
        }

        public Core.Domains.Entities.SecurityConfiguration GetSecurityConfiguration(int groupId)
        {
            var securityConfiguration = _context.SecurityConfigurations.Where(x => x.GroupId == groupId).FirstOrDefault();

            return new Core.Domains.Entities.SecurityConfiguration()
            {
                AllowAutonomousJoinersAndLeavers = securityConfiguration?.AllowAutonomousJoinersAndLeavers ?? false
            };
        }

        public List<int> GetGroupMembersForGivenRole(int groupId, GroupRoles roles, CancellationToken cancellationToken)
        {
            var users = _context.UserRole
                .Where(w => w.GroupId == groupId && w.RoleId == (int) roles)
                .Select(x=> x.UserId)
                .ToList();

            return users;
        }

        public List<List<int>> GetGroupActivityCredentialSets(int groupID, SupportActivities supportActivity)
        {
            List<List<int>> returnValue = new List<List<int>>();

            var credentialSets = _context.ActivityCredentialSet
                .Where(x => x.GroupId == groupID && x.ActivityId == (int)supportActivity)
                .OrderBy(x=> x.DisplayOrder)
                .Select(x => x.CredentialSetId)
                .ToList();

            if(credentialSets!=null && credentialSets.Count>0)
            {
                foreach(int credentialSet in credentialSets)
                {
                   var creds = _context.CredentialSet.Where(x => x.Id == credentialSet).Select(x => x.CredentialId).ToList();
                    returnValue.Add(creds);
                }
            }
            return returnValue;
        }

        public List<HelpMyStreet.Contracts.GroupService.Response.GroupCredential> GetGroupCredentials(int groupID)
        {
           var credentials = _context.GroupCredential
                .Where(x => x.GroupId == groupID)
                .Select(x => _mapper.Map<HelpMyStreet.Contracts.GroupService.Response.GroupCredential>(x))
                .ToList();
            return credentials;
        }

        public bool AddGroupMemberCredentials(PutGroupMemberCredentialsRequest request)
        {
            bool returnValue = false;

            _context.UserCredential.Add(new EntityFramework.Entities.UserCredential()
            {
                GroupId = request.GroupId,
                UserId = request.UserId,
                DateAdded = DateTime.Now,
                Notes = request.Notes,
                Reference = request.Reference,
                ValidUntil = request.ValidUntil,
                AuthorisedByUserId = request.AuthorisedByUserID,
                CredentialId = request.CredentialId,
            });

            int result = _context.SaveChanges();

            if(result==1)
            {
                returnValue = true;
            }
            return returnValue;
        }

        public GetGroupMemberDetailsResponse GetGroupMemberDetails(int groupId, int userId)
        {
            GetGroupMemberDetailsResponse returnValue = new GetGroupMemberDetailsResponse();

            var roles = _context.UserRole
                .Where(x => x.GroupId == groupId && x.UserId == userId)
                .Select(x => (GroupRoles)x.RoleId)
                .ToList();

            var audits = _context.UserRoleAudit
                .Where(x => x.UserId == userId && x.GroupId == groupId)
                .Select(x => _mapper.Map<HelpMyStreet.Utils.Models.UserRoleAudit>(x))
                .ToList();

            var credentials = _context.UserCredential
                .Where(x => x.UserId == userId && x.GroupId == groupId)
                .Select(x => _mapper.Map<HelpMyStreet.Utils.Models.UserCredential>(x)).ToList();

            returnValue.GroupRoles = roles;
            returnValue.UserRoleAudits = audits;
            returnValue.UserCredentials = credentials;

            return returnValue;
        }

        public UserInGroup GetGroupMember(int groupId, int userId)
        {
            var roles = _context.UserRole
                .Where(x => x.GroupId == groupId && x.UserId == userId)
                .Select(x => (GroupRoles) x.RoleId)
                .ToList();

            var allCredentials = _context.UserCredential
                .Where(x => x.UserId == userId 
                    && (x.GroupId == groupId || x.GroupId == (int) Groups.Generic) )
                .Select(x => new { x.CredentialId, x.ValidUntil})
                .ToList();

            var validCredentials = allCredentials.Where(x => ((x.ValidUntil ?? DateTime.Now.Date) - DateTime.Now.Date).TotalDays>=0)
                    .Select(x=> x.CredentialId)
                    .Distinct()
                .ToList();

            var audit = _context.UserRoleAudit
                .Where(x => x.UserId == userId && x.GroupId == groupId)
                .Select(x => _mapper.Map<HelpMyStreet.Utils.Models.UserRoleAudit>(x) )
                .ToList();


            UserInGroup userInGroup = new UserInGroup()
            {
                GroupRoles = roles,
                UserId = userId,
                GroupId = groupId,
                ValidCredentials = validCredentials,
                UserRoleAudit = audit
            };
            return userInGroup;
        }

        public List<UserInGroup> GetAllGroupMembers(int groupId)
        {
            List<UserInGroup> usersInGroups = new List<UserInGroup>();

            var users = _context.UserRole
                .Where(x => x.GroupId == groupId && x.RoleId == (int) GroupRoles.Member )
                .Select(x => x.UserId)
                .ToList();

            if (users != null && users.Count > 0)
            {
                foreach (int userId in users)
                {
                    usersInGroups.Add(GetGroupMember(groupId, userId));
                }
            }

            return usersInGroups;
        }

        public bool AddYotiVerifiedUsers(PutYotiVerifiedUserRequest request)
        {
            int credentialId_IdentityVerifiedByYoti = -1;
            int adminUserID = 1;

            return AddGroupMemberCredentials(new PutGroupMemberCredentialsRequest()
            {
                AuthorisedByUserID = adminUserID,
                CredentialId = credentialId_IdentityVerifiedByYoti,
                GroupId = (int)Groups.Generic,
                Notes = request.Notes,
                Reference = request.Reference,
                UserId = request.UserId,
                ValidUntil = null
            });
        }

        public CredentialVerifiedBy GetCredentialVerifiedBy(int groupId, int credentialId)
        {
            return _context.GroupCredential
                .Where(x => x.GroupId == groupId && x.CredentialId==credentialId)
                .Select(x => (CredentialVerifiedBy)x.CredentialVerifiedById).FirstOrDefault();
        }

        public bool UserHasRolesOtherThanVolunteerAndMember(int groupId, int userId, CancellationToken cancellationToken)
        {
            bool result = false;
            var roles = _context.UserRole.Where(x => x.GroupId == groupId && x.UserId == userId).Select(x => (GroupRoles)x.RoleId).ToList();
            if(roles!=null)
            {
                var roleCount = roles.Count(x => !x.Equals(GroupRoles.Member) && !x.Equals(GroupRoles.Volunteer));
                result = roleCount > 0 ? true : false;
            }
            return result;
        }

        public Instructions GetGroupSupportActivityInstructions(int groupId, SupportActivities supportActivities, CancellationToken cancellationToken)
        {
            string instruction = _context.GroupSupportActivityConfiguration
                .Include(i => i.SupportActivityInstructions)
                .Where(x => x.GroupId == groupId && x.SupportActivityId == (int)supportActivities)
                .Select(x => x.SupportActivityInstructions.Instructions)
                .FirstOrDefault();

            if(!String.IsNullOrEmpty(instruction))
            {
                return JsonConvert.DeserializeObject<Instructions>(instruction);
            }
            else
            {
                return new Instructions()
                {
                    Intro = "Please email mailto:contact@helpmystreet.org if you need any more information"
                };                
            }
           
        }

        public GetGroupNewRequestNotificationStrategyResponse GetGroupNewRequestNotificationStrategy(int groupId, CancellationToken cancellationToken)
        {
            var strategy = _context.GroupNewRequestNotificationStrategy.Where(x => x.GroupId == groupId).FirstOrDefault();
            
            if(strategy!=null)
            {
                return new GetGroupNewRequestNotificationStrategyResponse()
                {
                    NewRequestNotificationStrategy = (NewRequestNotificationStrategy)strategy.NewRequestNotificationStrategyId,
                    MaxVolunteer = strategy.MaxVolunteer
                };
            }
            else
            {
                throw new Exception($"Unable to find new request notification strategy for {groupId}");
            }            
        }

        public List<Core.Domains.Entities.GroupLocation> GetGroupLocations(List<int> groups, CancellationToken cancellationToken)
        {
            return _context.GroupLocation
                .Where(x => groups.Contains(x.GroupId))
                .Select(x => new Core.Domains.Entities.GroupLocation()
                {
                    GroupID = x.GroupId,
                    Location = (Location)x.LocationId
                }).ToList();
        }

        public List<SupportActivityDetail> GetSupportActivityDetails(RegistrationFormVariant registrationFormVariant, CancellationToken cancellationToken)
        {
            byte formVariant = (byte)registrationFormVariant;
            return _context.RegistrationFormSupportActivity
                .Where(x => x.RequestHelpFormVariantId == formVariant)
                .Select(x => new SupportActivityDetail()
                {
                    DisplayOrder = x.DisplayOrder,
                    IsPreSelected = x.IsPreSelected,
                    Label = x.Label,
                    SupportActivity = (SupportActivities) x.SupportActivityId
                }).ToList();

        }

        public List<HelpMyStreet.Utils.Models.SupportActivityConfiguration> GetSupportActivitiesConfiguration(CancellationToken cancellationToken)
        {
            return _context.SupportActivityConfiguration
                .Select(x => new HelpMyStreet.Utils.Models.SupportActivityConfiguration()
                {
                    SupportActivity = (SupportActivities)x.SupportActivityId,
                    AutoSignUpWhenOtherSelected = x.AutoSignUpWhenOtherSelected
                }).ToList();

        }

        public List<KeyValuePair<string, string>> GetGroupEmailConfiguration(int groupId, CommunicationJobTypes communicationJobType, CancellationToken cancellationToken)
        {

            var configuration  = _context.GroupEmailConfiguration
                .Where(x => x.GroupId == groupId && x.CommunicationJobTypeId == (byte)communicationJobType)
                .Select(x => x.Configuration)
                .FirstOrDefault();

            if(!string.IsNullOrEmpty(configuration))
            {
                return JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(configuration);
            }
            else
            {
                return new List<KeyValuePair<string, string>>();
            }
        }

        public async Task<bool> AddToGenericGroup(int groupId, string source)
        {
            var journey = _context.RegistrationJourney.FirstOrDefault(x => x.GroupId == groupId && x.Source == source);

            if(journey==null)
            {
                throw new Exception($"Expected journey for groupId {groupId} and source {source}");
            }

            switch ((TargetGroups) journey.TargetGroups)
            {
                case TargetGroups.GenericGroup:
                case TargetGroups.ThisGroupAndGenericGroup:
                    return true;
                default:
                    return false;
            }

            throw new NotImplementedException();
        }

        public List<HelpMyStreet.Utils.Models.Group> GetGroupsWithMapDetails(MapLocation mapLocation, CancellationToken cancellationToken)
        {
            byte location = (byte)mapLocation;

            var groups = _context.Group
                    .Include(x => x.GroupMapDetails)
                    .Where(c => c.GroupMapDetails.Any(i => i.MapLocationId == location));

            if (groups != null)
            {
                return _mapper.Map<List<HelpMyStreet.Utils.Models.Group>>(groups);
            }
            else
            {
                return new List<HelpMyStreet.Utils.Models.Group>();
            }
        }

        public double? GetGroupSupportActivityRadius(int groupId, SupportActivities supportActivities, CancellationToken cancellationToken)
        {
            var result = _context.GroupSupportActivityConfiguration
                .Where(x => x.GroupId == groupId && x.SupportActivityId == (int)supportActivities)
                .FirstOrDefault();

            if(result==null)
            {
                return null;
            }
            else
            {
                return result.Radius;
            }


        }

        public List<GroupSupportActivityRadius> GetGroupSupportActivityRadii(CancellationToken cancellationToken)
        {
            return  _context.GroupSupportActivityConfiguration
                .Select(x => new GroupSupportActivityRadius()
                {
                    Group = (Groups) x.GroupId,
                    SupportActivity = (SupportActivities) x.SupportActivityId,
                    SupportRadiusMiles = x.Radius
                }).ToList();
        }

        public async Task<int> MemberVolunterCount(IEnumerable<int> groups)
        {
            return _context.UserRole
                .Where(x => 
                    (((GroupRoles)x.RoleId) == GroupRoles.Member) &&
                    (groups.Count() == 0 || groups.Contains(x.GroupId)) 
                )
                .Select(x => x.UserId)
                .Distinct()
                .Count();
        }

        public async Task<int> MemberVolunterCountLastXDays(IEnumerable<int> groups, int days)
        {
            DateTime dtLessThanXDays = DateTime.UtcNow.Date.AddDays(-days);

            return _context.UserRoleAudit
                .Where(x => ((GroupRoles)x.RoleId) == GroupRoles.Member 
                    && (groups.Count() == 0 || groups.Contains(x.GroupId))
                    && ((GroupAction) x.ActionId) == GroupAction.AddMember 
                    && x.DateRequested > dtLessThanXDays
                    && x.Success == true
                    )
                .Select(x => x.UserId)
                .Distinct()
                .Count();
        }
        
        public List<GroupRadius> GetMaxShiftSupportActivityRadius(List<int> groups, CancellationToken cancellationToken)
        {
            var groupSupportActivityRadii = _context.GroupSupportActivityConfiguration
                .Where(x => groups.Contains(x.GroupId))
                .GroupBy(x => new { x.GroupId, x.Radius, x.SupportActivityId })
                .Select(s => new
                {
                    GroupID = s.Key.GroupId,
                    Radius = s.Max(m => m.Radius),
                    SupportActivity = (SupportActivities) (s.Key.SupportActivityId)
                })
                .ToList();

            var result = new List<GroupRadius>();

            groups.ForEach(g =>
            {
                var groupShiftSupportActivityRadii = groupSupportActivityRadii.Where(w => w.GroupID == g && w.SupportActivity.RequestType() == RequestType.Shift);
                double maxRadius = groupShiftSupportActivityRadii.Count()>0 ? groupShiftSupportActivityRadii.Select(x => x.Radius).Max() : 20d;
                result.Add(new GroupRadius()
                {
                    GroupID = g,
                    Radius = maxRadius
                });
            }
            );

            return result;
        }

        public async Task<List<UserRoleSummary>> GetUserRoleSummary(IEnumerable<int> groups, GroupAction action, DateTime minDate, DateTime maxDate)
        {
            int roleID_volunteer = (int)GroupRoles.Volunteer;
            return _context.UserRoleAudit
               .Where(x => x.RoleId!=roleID_volunteer && groups.Contains(x.GroupId) && x.Success == true && x.DateRequested >= minDate && x.DateRequested <= maxDate && x.ActionId == (int)action)
               .Select(s => new UserRoleSummary
               {
                   UserId = s.UserId,
                   DateRequested = s.DateRequested.Date,
                   Role = (GroupRoles)s.RoleId
               }).ToList();
        }

        public bool AllowRoleChange(GroupRoles roleToBeAssigned, int groupId, int authorisedByUserID, CancellationToken cancellationToken)
        {
            bool allowRole = false;
            var authorisingUserRoles = GetUserRoles(authorisedByUserID, cancellationToken);

            if (authorisingUserRoles != null && authorisingUserRoles.Count > 0)
            {
                var rolesForGivenGroup = authorisingUserRoles[groupId];
                if (rolesForGivenGroup != null && rolesForGivenGroup.Count > 0)
                {
                    if (rolesForGivenGroup.Contains((int)GroupRoles.Owner) && roleToBeAssigned != GroupRoles.Owner)
                    {
                        allowRole = true;
                    }
                    else if (rolesForGivenGroup.Contains((int)GroupRoles.UserAdmin) && roleToBeAssigned == GroupRoles.Member)
                    {
                        allowRole = true;
                    }
                }
            }
            return allowRole;
        }
        
        public async Task<List<UserRoleSummary>> GetTotalGroupUsersByType(IEnumerable<int> groups)
        {
            int roleID_volunteer = (int)GroupRoles.Volunteer;
            return _context.UserRole
               .Where(x => x.RoleId!=roleID_volunteer && groups.Contains(x.GroupId))
               .Select(s => new UserRoleSummary
               {
                   UserId = s.UserId,
                   Role = (GroupRoles)s.RoleId
               }).ToList();
         }
    }
}
