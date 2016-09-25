using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Migrations.DatabaseModel
{
    public class DiscountCoupon : EntityBase
    {
        public decimal Discount { get; private set; }
        public string Title { get; private set; }
        public string Code { get; private set; }        
    }
}
