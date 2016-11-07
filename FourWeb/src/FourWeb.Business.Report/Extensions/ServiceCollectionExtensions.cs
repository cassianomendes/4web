using FourWeb.Business.Report.Data.Contexts;
using FourWeb.Business.Report.Data.Repositories;
using FourWeb.Business.Report.Domain.Repositories;
using FourWeb.Business.Report.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FourWeb.Business.Report.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static void AddReportContexts(this IServiceCollection services)
        {
            services.AddDbContext<ReportContext>();
        }
        public static void AddReport(this IServiceCollection services)
        {
            services.AddReportContexts();

            // Repositories
            services.AddScoped<ICustomerRepositoryQuery, CustomerRepositoryQuery>();
            services.AddScoped<IOrderRepositoryQuery, OrderRepositoryQuery>();

            // Services
            services.AddScoped<OrderService>();
        }
    }
}
