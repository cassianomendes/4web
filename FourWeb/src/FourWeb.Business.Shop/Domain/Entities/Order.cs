using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Shop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Order : EntityBase
    {
        protected Order()
        {

        }

        public Order(IList<OrderItem> orderItems, int customer)
        {
            this.Date = DateTime.Now;            
            orderItems.ToList().ForEach(x => AddItem(x));
            this.CustomerId = customer;
            this.Status = OrderStatus.Created;
        }

        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }        
        public decimal Total
        {
            get
            {
                return OrderItems.Sum(x => x.Subtotal);
            }
        }
        public OrderStatus Status { get; set; }

        public int PaymentId { get; private set; }
        public Payment Payment { get; private set; }
        public int PaymentMethodId { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public int ShippingId { get; private set; }
        public Shipping Shipping { get; private set; }

        public int DiscountCouponId { get; set; }
        public DiscountCoupon DiscountCoupon { get; private set; }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void MarkAsPaid()
        {
            // Dá baixa no estoque
            this.Status = OrderStatus.Paid;
        }

        public void MarkAsDelivered()
        {
            this.Status = OrderStatus.Delivered;
        }
            
        public void Cancel()
        {
            // Estorna os produtos
            // ...
            this.Status = OrderStatus.Canceled;
        }
    }
}
