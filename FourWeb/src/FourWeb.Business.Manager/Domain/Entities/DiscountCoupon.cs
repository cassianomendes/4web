using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class DiscountCoupon : EntityBase
    {
        public DiscountCoupon(string title, decimal discount, string code)
        {
            this.Title = title;
            this.Discount = discount;
            this.Code = code;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public decimal Discount { get; private set; }
        public string Code { get; private set; }
    }
}
