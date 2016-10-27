using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Data.Repositories;
using FourWeb.Business.Shop.Domain.Repositories;
using FourWeb.Business.Shop.Domain.Services;
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
            services.AddScoped<IDiscountCouponRepositoryQuery, DiscountCouponRepositoryQuery>();
            services.AddScoped<IOrderRepositoryQuery, OrderRepositoryQuery>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

            // Services
            services.AddScoped<CouponService>();
            services.AddScoped<OrderService>();
            services.AddScoped<ShoppingCartService>();
        }
    }
}
