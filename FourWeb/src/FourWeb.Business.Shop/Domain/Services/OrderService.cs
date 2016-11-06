using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Factories;
using FourWeb.Business.Shop.Domain.Repositories;

namespace FourWeb.Business.Shop.Domain.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IDiscountCouponRepositoryQuery _discountCouponRepositoryQuery;
        private readonly ShoppingCartService _shoppingCartService;        


        public OrderService(IOrderRepository orderRepository, IDiscountCouponRepositoryQuery discountCouponRepositoryQuery, ShoppingCartService shoppingCartService)
        {
            _orderRepository = orderRepository;
            _discountCouponRepositoryQuery = discountCouponRepositoryQuery;
            _shoppingCartService = shoppingCartService;            
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void ProcessOrder(string email, PaymentMethod paymentMethod, Payment payment, 
                                 Address address, string code)
        {
            var shoppingCart = _shoppingCartService.GetByCustomer(email);

            var order = OrderFactory.CreateOrder(shoppingCart);
            var shipping = Shipping.Create(address);
            var coupon = _discountCouponRepositoryQuery.GetByCode(code);

            order.ChangePayment(payment);
            order.ChangePaymentMethod(paymentMethod);
            order.ChangeShipping(shipping);
            order.ApplyDiscountCoupon(coupon);

            _orderRepository.Add(order);
        }
    }
}
