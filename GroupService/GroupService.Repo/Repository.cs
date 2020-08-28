using AutoMapper;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
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
                int result = _context.SaveChanges();
                if (result == 1)
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

        public List<int> GetUserGroups(GetUserGroupsRequest request, CancellationToken cancellationToken)
        {
            return _context.UserRole
                .Where(w => w.UserId == request.UserID)
                .Select(s => s.GroupId).ToList();
        }

        public Dictionary<int, List<int>> GetUserRoles(GetUserRolesRequest request, CancellationToken cancellationToken)
        {
            Dictionary<int, List<int>> response = new Dictionary<int, List<int>>();

            var roles = _context.UserRole
                .Where(w => w.UserId == request.UserID).ToList();

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

        public async Task<bool> RevokeRoleAsync(PostRevokeRoleRequest request, CancellationToken cancellationToken)
        {
            bool success = false;
            
            _context.UserRole.Remove(_context.UserRole.First(
            w => w.UserId == request.UserID.Value &&
            w.GroupId == request.GroupID.Value &&
            w.RoleId == (int)request.Role.GroupRole));

            int result = await _context.SaveChangesAsync(cancellationToken);
            if (result == 1)
            {
                success = true;
            }
            return success;
        }

        public void AddUserRoleAudit(int groupId, int userId, GroupRoles groupRole, int authorisedByUserID, GroupAction groupAction, bool success, CancellationToken cancellationToken)
        {
            _context.UserRoleAudit.Add(new UserRoleAudit()
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

        public List<int> GetGroupMembers(GetGroupMembersRequest request, CancellationToken cancellationToken)
        {
            return _context.UserRole
                .Where(w => w.GroupId == request.GroupID)
                .Select(s => s.UserId)
                .Distinct().ToList();
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
            var group = _context.Group.FirstOrDefault(x => x.Id == groupId);

            if (group != null)
            {
                return new HelpMyStreet.Utils.Models.Group()
                {
                    GroupId = group.Id,
                    GroupName = group.GroupName,
                    GroupKey = group.GroupKey,
                    ParentGroupId = group.ParentGroupId
                };
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
                return groups.Select(x => new HelpMyStreet.Utils.Models.Group()
                {
                    GroupId = x.Id,
                    GroupKey = x.GroupKey,
                    GroupName = x.GroupName,
                    ParentGroupId = x.ParentGroupId
                }).ToList();
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
            if(source==null)
            {
                source = string.Empty;
            }
            var requestHelpJourney = _context.RequestHelpJourney.FirstOrDefault(x => x.GroupId == groupId && x.Source == source);

            if (requestHelpJourney != null)
            {
                return new GetRequestHelpFormVariantResponse()
                {
                    RequestHelpFormVariant = (RequestHelpFormVariant)requestHelpJourney.RequestHelpFormVariant,
                    TargetGroups = (TargetGroups)requestHelpJourney.TargetGroups,
                };
            }
            else
            {
                throw new Exception($"GroupId {groupId} Source {source} not found in RequestHelpJourney");
            }
        }
    }
}
