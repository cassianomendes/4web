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

        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }

        public decimal Subtotal
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }

        public void AddProduct(Product product, int quantity, decimal price)
        {
            this.ProductId = product.Id;
            this.Product = product;
            this.Quantity = quantity;
            this.Price = price;

            // Reserva o estoque
            this.Product.UpdateQuantityOnHand(this.Product.QuantityOnHand - quantity);
        }
    }
}
