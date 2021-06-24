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
                .ForMember(x => x.GroupId, x => x.MapFrom(m => m.Id))
                .ForMember(x => x.GroupType, x => x.MapFrom(m => (GroupTypes)m.GroupType))
                .ForMember(x => x.Maps, x => x.MapFrom(m => m.GroupMapDetails));

            CreateMap<Repo.EntityFramework.Entities.GroupMapDetails, HelpMyStreet.Utils.Models.MapDetails>()
                .ForMember(x => x.MapLocation, x => x.MapFrom(m => (MapLocation)m.MapLocationId));
        }
    }
}
