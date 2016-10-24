using FourWeb.Business.Identity.Data.Context;
using FourWeb.Business.Identity.Data.Repositories;
using FourWeb.Business.Identity.Domain.Repositories;
using FourWeb.Business.Identity.Domain.Services;
using FourWeb.Infrastructure.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddAuthorization(a => a.AddPolicy(AuthenticationConstants.FourWebAuthenticationPolicy,
                builder => builder.AddAuthenticationSchemes(AuthenticationConstants.FourWebAuthenticationScheme)
                                  .RequireAuthenticatedUser().Build()));
        }
    }
}
