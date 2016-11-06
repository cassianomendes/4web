using FourWeb.Business.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Factories
{
    public class OrderFactory
    {
        public static Order CreateOrder(ShoppingCart shoppingCart)
        {
            var order = Order.Create(shoppingCart.Customer);
            ParseShoppingCartItems(shoppingCart.ShoppingCartItems, order);

            return order;
        }

        private static void ParseShoppingCartItems(ICollection<ShoppingCartItem> items, Order order)
        {
            foreach (var item in items)
                order.AddItem(OrderItem.Create(order, item.Product, item.Quantity));
        }
    }
}
