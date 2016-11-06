using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        public OrderItem() { }        
        public int Quantity { get; private set; }
        public decimal UnitCost { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }

        public decimal Subtotal
        {
            get
            {
                return this.UnitCost * this.Quantity;
            }
        }

        public void AddProduct(Product product, int quantity, decimal unitCost)
        {
            this.ProductId = product.Id;
            this.Product = product;
            this.Quantity = quantity;
            this.UnitCost = unitCost;

            // Reserva o estoque
            this.Product.UpdateQuantityOnHand(this.Product.QuantityOnHand - quantity);
        }

        public static OrderItem Create(Order order, Product product, int quantity)
        {
            return new OrderItem()
            {
                Product = product,
                ProductId = product.Id,
                Quantity = quantity,
                Order = order,
                OrderId = order.Id,
                UnitCost = product.Price
            };
        }
    }
}
