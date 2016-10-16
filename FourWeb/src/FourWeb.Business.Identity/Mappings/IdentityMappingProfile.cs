using AutoMapper;
using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Identity.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Mappings
{
    public class IdentityMappingProfile : Profile
    {
        public IdentityMappingProfile()
        {
            FromInputModelToDomainModel();
        }
        private void FromInputModelToDomainModel()
        {
            CreateMap<UserInputModel, User>();
        }
    }
}
