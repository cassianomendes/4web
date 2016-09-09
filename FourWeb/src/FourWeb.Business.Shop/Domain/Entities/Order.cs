using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Shop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Order : EntityBase
    {
        public Order(IList<OrderItem> orderItems, int userId)
        {
            this.Date = DateTime.Now;
            this._orderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(x => AddItem(x));
            this.UserId = userId;
            this.Status = OrderStatus.Created;
        }        
        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public int UserId { get; set; }
        public User User { get; set; }
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
