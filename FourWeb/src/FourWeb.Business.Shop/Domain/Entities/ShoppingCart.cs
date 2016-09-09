using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        protected ShoppingCart()
        {
            this.ShoppingCartItems = new List<ShoppingCartItem>();
        }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; protected set; }
        public int Quantity { get; private set; }
    }
}
