using FourWeb.Business.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Factories
{
    public class OrderItemFactory
    {
        public static OrderItem CreateOrderItem(Order order, ShoppingCartItem shoppingCartItem)
        {
            return OrderItem.Create(order, shoppingCartItem.Product, shoppingCartItem.Quantity);
        }
    }
}
