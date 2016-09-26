using FourWeb.Business.Shop.Data.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace FourWeb.Business.Shop.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static void AddShopContexts(this IServiceCollection services)
        {
            services.AddDbContext<ShopContext>();
        }
        public static void AddManager(this IServiceCollection services)
        {
            services.AddShopContexts();

            //services.AddScoped<CategoryService>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
