using AutoMapper;
using GroupService.Core.Dto;
using GroupService.Repo.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupService.Mappers
{
    public class AddressDetailsProfile : Profile
    {
        public AddressDetailsProfile()
        {
            CreateMap<AddressDetails, AddressDetailsDTO>();
            CreateMap<AddressDetailsDTO, AddressDetails>();
        }
    }
}
