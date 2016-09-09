using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class DiscountCoupon : EntityBase
    {
        protected DiscountCoupon()
        {
        }

        public string Code { get; private set; }

        public static DiscountCoupon Create(string code)
        {
            return new DiscountCoupon()
            {
                Code = code
            };
        }
    }
}
