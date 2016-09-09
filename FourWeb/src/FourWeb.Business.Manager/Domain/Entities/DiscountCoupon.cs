using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class DiscountCoupon : EntityBase
    {
        protected DiscountCoupon()
        {
        }

        public string Title { get; private set; }
        public decimal Discount { get; private set; }
        public string Code { get; private set; }

        public static DiscountCoupon Create(string title, decimal discount, string code)
        {
            return new DiscountCoupon()
            {
                Title = title,
                Discount = discount,
                Code = code
            };
        }
    }
}
