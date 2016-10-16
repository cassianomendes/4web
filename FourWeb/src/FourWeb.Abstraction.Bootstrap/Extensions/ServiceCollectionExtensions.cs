using AutoMapper;
using FourWeb.Business.Identity.Extensions;
using FourWeb.Business.Manager.Extensions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Abstraction.Bootstrap.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(c =>
            {
                c.AddManagerMappings();
                c.AddIdentityMappings();
            });

            services.AddSingleton<IMapper>(new Mapper(configuration));
        }

        public static void AddModules(this IServiceCollection services)
        {            
            services.AddAutoMapper();

            services.AddManager();
            services.AddIdentity();
        }
    }
}
