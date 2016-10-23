using System;
using AutoMapper;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.InputModels;
using FourWeb.Business.Shop.ViewModels;

namespace FourWeb.Business.Shop.Mappings
{
    public class ShopMappingProfile : Profile
    {
        public ShopMappingProfile()
        {
            FromInputModelToDomainModel();
            FromDomainModelToViewModel();
        }

        private void FromInputModelToDomainModel()
        {
            CreateMap<ShoppingCartItemInputModel, ShoppingCartItem>();
        }

        private void FromDomainModelToViewModel()
        {
            CreateMap<ShoppingCart, ShoppingCartViewModel>()
                .ForMember(
                    dest => dest.Items,
                    opt => opt.MapFrom(src => src.ShoppingCartItems)
                );

            CreateMap<ShoppingCartItem, ShoppingCartItemViewModel>()
                .ForMember(
                    dest => dest.ProductName,
                    opt => opt.MapFrom(src => src.Product.Title)
                )
                .ForMember(
                    dest => dest.ProductPrice,
                    opt => opt.MapFrom(src => src.Product.Price)
                )
                .ForMember(
                    dest => dest.Quantity,
                    opt => opt.MapFrom(src => src.Quantity)
                );
        }
    }
}
