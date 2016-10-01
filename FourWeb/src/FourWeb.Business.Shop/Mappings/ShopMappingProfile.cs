using AutoMapper;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.InputModels;

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
            CreateMap<ShoppingCartItemInputModel, ShoppingCartItem>();
        }
    }
}
