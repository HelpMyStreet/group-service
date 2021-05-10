using AutoMapper;
using HelpMyStreet.Utils.Enums;
using System;

namespace GroupService.Mappers
{
    public class UserRoleAuditProfile : Profile
    {
        public UserRoleAuditProfile()
        {
            CreateMap<Repo.EntityFramework.Entities.UserRoleAudit, HelpMyStreet.Utils.Models.UserRoleAudit>()
                .ForMember(x => x.Role, x => x.MapFrom(m => (GroupRoles)m.RoleId))
                .ForMember(x => x.Action, x => x.MapFrom(m => (GroupAction)m.ActionId));
        }
    }
}
