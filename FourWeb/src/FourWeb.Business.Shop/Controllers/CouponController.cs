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
        private readonly ShoppingCartService _shoppingCartService;

        public CouponController(CouponService couponService, ShoppingCartService shoppingCartService)
        {
            _couponService = couponService;
            _shoppingCartService = shoppingCartService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CalcDiscountCouponInputModel inputModel)
        {
            var shoppingCart = _shoppingCartService.GetByCustomer(User.Identity.Name);
            return Ok(_couponService.CalculateDiscount(inputModel.Code, shoppingCart));
        }
    }
}
