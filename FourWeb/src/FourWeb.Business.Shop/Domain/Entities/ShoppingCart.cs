using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        private IList<ShoppingCartItem> _shoppingCartItems;

        public ShoppingCart()
        {
            _shoppingCartItems = new List<ShoppingCartItem>();
        }

        public ICollection<ShoppingCartItem> ShoppingCartItems
        {
            get { return _shoppingCartItems; }
            private set { _shoppingCartItems = new List<ShoppingCartItem>(value); }
        }

        public int Id { get; set; }
        public int Quantity { get; set; }

    }
}
