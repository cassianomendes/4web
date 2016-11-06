using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Repositories;
using System;

namespace FourWeb.Business.Shop.Domain.Services
{
    public class CouponService
    {
        private readonly IDiscountCouponRepositoryQuery _discountCouponRepositoryQuery;

        public CouponService(IDiscountCouponRepositoryQuery discountCouponRepositoryQuery)
        {
            _discountCouponRepositoryQuery = discountCouponRepositoryQuery;
        }

        public decimal CalculateDiscount(string code, Order order)
        {
            if (code == null) throw new ArgumentNullException(nameof(code));
            if (order == null) throw new ArgumentNullException(nameof(order));

            var coupon = _discountCouponRepositoryQuery.GetByCode(code);
            return order.Total - (order.Total * coupon.Discount);
        }

        public decimal CalculateDiscount(string code, ShoppingCart shoppingCart)
        {
            if (code == null) throw new ArgumentNullException(nameof(code));
            if (shoppingCart == null) throw new ArgumentNullException(nameof(shoppingCart));

            var coupon = _discountCouponRepositoryQuery.GetByCode(code);
            return shoppingCart.Total - (shoppingCart.Total * coupon.Discount);
        }
    }
}
