using AutoMapper;
using FourWeb.Business.Shop.Mappings;

namespace FourWeb.Business.Shop.Extensions
{
    public static class MapperConfigurationExtensions
    {
        public static void AddShopMappings(this IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<ShopMappingProfile>();
        }
    }
}
