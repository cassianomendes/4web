using FourWeb.Business.Shop.Domain.Services;
using FourWeb.Business.Shop.InputModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourWeb.Business.Shop.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CouponController : Controller
    {
        private readonly CouponService _couponService;
        private readonly OrderService _orderService;

        public CouponController(CouponService couponService, OrderService orderService)
        {
            _couponService = couponService;
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CalcDiscountCouponInputModel inputModel)
        {
            var order = _orderService.GetById(inputModel.OrderId);
            return Ok(_couponService.CalculateDiscount(inputModel.Code, order));
        }
    }
}
