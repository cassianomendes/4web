﻿using AutoMapper;
using FourWeb.Business.Identity.Extensions;
using FourWeb.Business.Manager.Extensions;
using FourWeb.Business.Report.Extensions;
using FourWeb.Business.Shop.Extensions;
using FourWeb.ExternalServices.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace FourWeb.Abstraction.Bootstrap.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(c =>
            {
                c.AddIdentityMappings();
                c.AddManagerMappings();
                c.AddReportMappings();
                c.AddShopMappings();
            });

            services.AddSingleton<IMapper>(new Mapper(configuration));
        }

        public static void AddModules(this IServiceCollection services)
        {            
            services.AddAutoMapper();

            services.AddExternalServices();
            services.AddIdentity();
            services.AddManager();
            services.AddReport();
            services.AddShop();
        }
    }
}
