using Microsoft.Extensions.DependencyInjection;
using FourWeb.ExternalServices.Correios;

namespace FourWeb.ExternalServices.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddExternalServices(this IServiceCollection services)
        {
            services.AddScoped<CorreiosService>();
        }
    }
}
