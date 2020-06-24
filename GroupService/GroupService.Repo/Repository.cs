using AutoMapper;
using GroupService.Core.Dto;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Contracts.GroupService.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public async Task<int> CreateGroupAsync(PostCreateGroupRequest request, CancellationToken cancellationToken)
        {
            int? parentGroupId = null;
            
            var group = _context.Group.FirstOrDefault(x => x.GroupName == request.GroupName);

            if (group != null)
            {
                throw new Exception($"{request.GroupName} already exists as a group");
            }

            Group parentGroup = null;

            if(request.ParentGroupName!=null)
            {
                parentGroup = _context.Group.FirstOrDefault(x => x.GroupName == request.ParentGroupName);
                if (group == null)
                {
                    throw new Exception($"{request.ParentGroupName} does not exists as a group and cannot therefore be linked as a parent group");
                }
                parentGroupId = parentGroup.Id;
            }

            Group g = new Group()
            {
                GroupName = request.GroupName,
                ParentGroupId = parentGroupId
            };
            _context.Group.Add(g);
            await _context.SaveChangesAsync(cancellationToken);
            return g.Id;         
        }

        public List<int> GetUserGroups(GetUserGroupsRequest request, CancellationToken cancellationToken)
        {
            return _context.Role
                .Where(w => w.UserId == request.UserID)
                .Select(s => s.GroupId).ToList();
        }
    }
}
