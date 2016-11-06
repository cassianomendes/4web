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

        protected Order(IList<OrderItem> orderItems, Customer customer)
        {
            this.Date = DateTime.Now;            
            orderItems.ToList().ForEach(x => AddItem(x));
            this.CustomerId = customer.Id;
            Customer = customer;
            this.Status = OrderStatus.Created;
        }

        protected Order(Customer customer)
        {
            this.Date = DateTime.Now;            
            Customer = customer;
            this.Status = OrderStatus.Created;
        }

        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }        
        public decimal Total { get; private set; }
        public OrderStatus Status { get; private set; }

        public int PaymentId { get; private set; }
        public Payment Payment { get; private set; }
        public int PaymentMethodId { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public int ShippingId { get; private set; }
        public Shipping Shipping { get; private set; }

        public int DiscountCouponId { get; private set; }
        public DiscountCoupon DiscountCoupon { get; private set; }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);

            Total += item.Subtotal;
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

        public void ApplyDiscountCoupon(DiscountCoupon coupon)
        {
            DiscountCoupon = coupon;
            DiscountCouponId = coupon.Id;

            Total -= Total * coupon.Discount;
        }

        public void ChangePayment(Payment payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));

            Payment = payment;
            PaymentId = payment.Id;
        }

        public void ChangePaymentMethod(PaymentMethod paymentMethod)
        {
            if (paymentMethod == null) throw new ArgumentNullException(nameof(paymentMethod));

            PaymentMethod = paymentMethod;
            PaymentMethodId = paymentMethod.Id;
        }

        public void ChangeShipping(Shipping shipping)
        {
            if (shipping == null) throw new ArgumentNullException(nameof(shipping));

            Shipping = shipping;
            ShippingId = shipping.Id;
        }

        public static Order Create(Customer customer)
        {
            return new Order(customer);
        }
    }
}
