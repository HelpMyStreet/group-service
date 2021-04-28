using AutoMapper;
using HelpMyStreet.Utils.Enums;
using System;

namespace GroupService.Mappers
{
    public class GroupCredentialProfile : Profile
    {
        public GroupCredentialProfile()
        {
            CreateMap<Repo.EntityFramework.Entities.GroupCredential, HelpMyStreet.Contracts.GroupService.Response.GroupCredential>()
                .ForMember(x => x.CredentialTypes, x => x.MapFrom(m => (CredentialTypes) m.CredentialTypeId))
                .ForMember(x => x.CredentialVerifiedBy, x => x.MapFrom(m => (CredentialVerifiedBy) m.CredentialVerifiedById));
        }
    }
}
