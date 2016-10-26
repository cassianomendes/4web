using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Shop.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Repositories
{
    public interface IDiscountCouponRepositoryQuery : IRepositoryQueryBase<DiscountCoupon>
    {
        DiscountCoupon GetByCode(string code);
    }
}
