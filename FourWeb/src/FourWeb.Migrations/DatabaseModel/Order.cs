using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Shop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Migrations.DatabaseModel
{
    public class Order : EntityBase
    {

        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }        
        public OrderStatus Status { get; set; }

        public int PaymentId { get; private set; }
        public Payment Payment { get; private set; }
        public int PaymentMethodId { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public int ShippingId { get; private set; }
        public Shipping Shipping { get; private set; }

        public int DiscountCouponId { get; set; }
        public DiscountCoupon DiscountCoupon { get; private set; }

    }
}
