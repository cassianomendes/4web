using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ShoppingCartItem : EntityBase
    {
        protected ShoppingCartItem()
        {

        }        
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public void UpdateQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
