using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ShoppingCartItem : EntityBase
    {
        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }

        public int Quantity { get; private set; }
    }
}
