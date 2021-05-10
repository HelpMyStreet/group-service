using AutoMapper;
using HelpMyStreet.Utils.Enums;
using System;

namespace GroupService.Mappers
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Repo.EntityFramework.Entities.Group, HelpMyStreet.Utils.Models.Group>()
                .ForMember(x => x.GroupId, x => x.MapFrom(m => m.Id));
        }
    }
}
