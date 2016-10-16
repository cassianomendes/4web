using AutoMapper;
using FourWeb.Business.Identity.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Extensions
{
    public static class MapperConfigurationExtensions
    {
        public static void AddIdentityMappings(this IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<IdentityMappingProfile>();
        }
    }
}
