using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Data.Repositories;
using FourWeb.Business.Shop.Domain.Repositories;
using FourWeb.Business.Shop.Domain.Services;
using FourWeb.ExternalServices.Correios;
using Microsoft.Extensions.DependencyInjection;

namespace FourWeb.Business.Shop.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static void AddShopContexts(this IServiceCollection services)
        {
            services.AddDbContext<ShopContext>();
        }
        public static void AddShop(this IServiceCollection services)
        {
            services.AddShopContexts();

            // Repositories
            services.AddScoped<ICustomerRepositoryQuery, CustomerRepositoryQuery>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

            // Services
            services.AddScoped<ShoppingCartService>();

            // External Services
            services.AddScoped<CorreiosService>();
        }
    }
}
