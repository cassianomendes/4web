using AutoMapper;
using FourWeb.Business.Manager.Domain.Entities;
using FourWeb.Business.Manager.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Mappings
{
    public class ManagerMappingProfile : Profile
    {
        public ManagerMappingProfile()
        {
            FromInputModelToDomainModel();
        }

        private void FromInputModelToDomainModel()
        {
            CreateMap<CategoryInputModel, Category>();
        }
    }
}
