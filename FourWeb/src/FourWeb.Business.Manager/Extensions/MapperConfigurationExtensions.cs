using AutoMapper;
using FourWeb.Business.Manager.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Extensions
{
    public static class MapperConfigurationExtensions
    {
        public static void AddManagerMappings(this IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<ManagerMappingProfile>();
        }
    }
}
