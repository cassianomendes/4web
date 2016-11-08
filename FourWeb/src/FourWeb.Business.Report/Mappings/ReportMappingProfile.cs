using AutoMapper;
using FourWeb.Business.Report.Domain.Entities;
using FourWeb.Business.Report.ViewModels;

namespace FourWeb.Business.Report.Mappings
{
    public class ReportMappingProfile : Profile
    {
        public ReportMappingProfile()
        {
            FromInputModelToDomainModel();
            FromDomainModelToViewModel();
        }

        private void FromInputModelToDomainModel()
        {
        }

        private void FromDomainModelToViewModel()
        {
            CreateMap<Order, OrderViewModel>();

            CreateMap<Order, OrderDetailViewModel>()
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.DiscountCoupon == null ? 0 : src.DiscountCoupon.Discount))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.OrderItems))
                .ForMember(dest => dest.ShippingAddress, opt => opt.MapFrom(src => src.Shipping))
                .ForMember(dest => dest.Payment, opt => opt.MapFrom(src => src.Payment));

            CreateMap<OrderItem, OrderDetailItemViewModel>()
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.UnitCost, opt => opt.MapFrom(src => src.UnitCost))
                .ForMember(dest => dest.ProductTitle, opt => opt.MapFrom(src => src.Product.Title));

            CreateMap<Shipping, OrderDetailShippingAddressViewModel>()
                .ForMember(dest => dest.Address1, opt => opt.MapFrom(src => src.Address.Address1))
                .ForMember(dest => dest.Address2, opt => opt.MapFrom(src => src.Address.Address2))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Address.Country))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Address.Name))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.Address.Province));

            CreateMap<Payment, OrderDetailPaymentViewModel>()
                .ForMember(dest => dest.Paid, opt => opt.MapFrom(src => src.Paid))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total));
        }
    }
}
