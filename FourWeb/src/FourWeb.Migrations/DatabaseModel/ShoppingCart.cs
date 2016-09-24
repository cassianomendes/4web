using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.DatabaseModel
{
    public class ShoppingCart : EntityBase
    {    
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; protected set; }
        public int Quantity { get; private set; }
        public Customer Customer { get; private set; }        
    }
}
