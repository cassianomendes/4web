using FourWeb.Business.Report.Data.Contexts;
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
        }
    }
}
