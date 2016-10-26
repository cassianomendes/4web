using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Shop.Data.Contexts;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using System.Linq;

namespace FourWeb.Business.Shop.Data.Repositories
{
    public class DiscountCouponRepositoryQuery : RepositoryQueryBase<DiscountCoupon>, IDiscountCouponRepositoryQuery
    {
        public DiscountCouponRepositoryQuery(ShopContext context)
            : base(context)
        {
        }

        public DiscountCoupon GetByCode(string code)
        {
            return base.Entity.SingleOrDefault(x => x.Code == code);
        }
    }
}
