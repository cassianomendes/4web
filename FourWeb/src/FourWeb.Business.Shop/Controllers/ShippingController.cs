using FourWeb.Business.Shop.Domain.Services;
using FourWeb.Business.Shop.InputModels;
using FourWeb.Business.Shop.ViewModels;
using FourWeb.ExternalServices.Correios;
using Microsoft.AspNetCore.Mvc;

namespace FourWeb.Business.Shop.Controllers
{
    [Route("api/[controller]")]
    public class ShippingController : Controller
    {
        private const string _defaultSourcePostalCode = "95760000";
        private readonly CorreiosService _correiosService;
        private readonly ShoppingCartService _shoppingCartService;

        public ShippingController(CorreiosService correiosService, ShoppingCartService shoppingCartService)
        {
            _correiosService = correiosService;
            _shoppingCartService = shoppingCartService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ShippingInputModel inputModel)
        {
            var shoppingCart = _shoppingCartService.GetByCustomer(User.Identity.Name);
            var product= shoppingCart.GetBiggerProduct();

            var result = _correiosService.CalculatePriceAndDeadlineAsync(
                _defaultSourcePostalCode,
                inputModel.PostalCode,
                product.GetWeightInKg(),
                product.GetLength(),
                product.GetHeight(),
                product.GetWidth(),
                product.GetDiagonal()).Result;

            var viewModel = new ShippingViewModel
            {
                //Address = new ShippingAddressViewModel
                //{
                //    Province = "",
                //    City = "",
                //    Address = ""
                //},
                ShippingPrice = result.Valor,
                TotalWeekdays = result.PrazoEntrega
            };

            return Ok(viewModel);
        }
    }
}
