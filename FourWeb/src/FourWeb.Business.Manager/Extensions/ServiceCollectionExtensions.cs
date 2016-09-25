using FourWeb.Business.Manager.Data.Contexts;
using FourWeb.Business.Manager.Data.Repositories;
using FourWeb.Business.Manager.Domain.Repositories;
using FourWeb.Business.Manager.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static void AddManagerContexts(this IServiceCollection services)
        {
            services.AddDbContext<ManagerContext>();
        }
        public static void AddManager(this IServiceCollection services)
        {
            services.AddManagerContexts();

            services.AddScoped<CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();            
        }
    }
}
