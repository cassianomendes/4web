using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        protected OrderItem() { }
        public int Quantity { get; private set; }
        public decimal UnitCost { get; private set; }
        public Product Product { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }
    }
}
