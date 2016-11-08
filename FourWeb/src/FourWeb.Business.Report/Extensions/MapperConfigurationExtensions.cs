using AutoMapper;
using FourWeb.Business.Report.Mappings;

namespace FourWeb.Business.Report.Extensions
{
    public static class MapperConfigurationExtensions
    {
        public static void AddReportMappings(this IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<ReportMappingProfile>();
        }
    }
}
