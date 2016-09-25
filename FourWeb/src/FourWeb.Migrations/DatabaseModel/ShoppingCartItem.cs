using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Migrations.DatabaseModel
{
    public class ShoppingCartItem : EntityBase
    {
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
    }
}
