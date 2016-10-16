using FourWeb.Business.Identity.Data.Context;
using FourWeb.Business.Identity.Data.Repositories;
using FourWeb.Business.Identity.Domain.Repositories;
using FourWeb.Business.Identity.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static void AddIdentityContexts(this IServiceCollection services)
        {
            services.AddDbContext<IdentityContext>();
        }
        public static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentityContexts();

            services.AddScoped<UserService>();
            services.AddScoped<IUserRepository, UserRepository>();            
        }
    }
}
