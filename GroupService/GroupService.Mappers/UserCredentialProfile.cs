using AutoMapper;
using HelpMyStreet.Utils.Enums;
using System;

namespace GroupService.Mappers
{
    public class UserCredentialProfile : Profile
    {
        public UserCredentialProfile()
        {
            CreateMap<Repo.EntityFramework.Entities.UserCredential, HelpMyStreet.Utils.Models.UserCredential>()
                .ForMember(x => x.ExpiryDate, x => x.MapFrom(m => m.ValidUntil));                
        }
    }
}
