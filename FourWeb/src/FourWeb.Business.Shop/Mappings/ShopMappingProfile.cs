using AutoMapper;

namespace FourWeb.Business.Shop.Mappings
{
    public class ShopMappingProfile : Profile
    {
        public ShopMappingProfile()
        {
            FromInputModelToDomainModel();
        }

        private void FromInputModelToDomainModel()
        {
            //CreateMap<CategoryInputModel, Category>();
        }
    }
}
