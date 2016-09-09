using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class ShoppingCart : EntityBase
    {
        public ShoppingCart()
        {
           ShoppingCartItems = new List<ShoppingCartItem>();
        }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; protected set; }        
        public int Quantity { get; set; }
    }
}
