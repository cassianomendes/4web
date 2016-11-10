using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FourWeb.Business.Report.Domain.Entities
{
    public class Order : EntityBase
    {
        protected Order()
        {

        }

        public DateTime Date { get; private set; }
        public int CustomerId { get; private set; }
        public decimal Total { get; private set; }
        public int Status { get; private set; }
        public Shipping Shipping { get; private set; }
        public DiscountCoupon DiscountCoupon { get; private set; }
        public Payment Payment { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
    }
}
