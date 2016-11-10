using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class DiscountCoupon : EntityBase
    {
        protected DiscountCoupon()
        {
        }
        public decimal Discount { get; private set; }
    }
}
