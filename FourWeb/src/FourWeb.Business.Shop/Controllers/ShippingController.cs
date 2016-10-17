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

        public ShippingController(CorreiosService correiosService)
        {
            _correiosService = correiosService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ShippingInputModel inputModel)
        {
            var result = _correiosService.CalculatePriceAndDeadlineAsync(
                _defaultSourcePostalCode,
                inputModel.PostalCode,
                20,
                10,
                10,
                10,
                10).Result;

            // TODO: Informações de endereço referente ao CEP informado

            var viewModel = new ShippingViewModel
            {
                Address = new ShippingAddressViewModel
                {
                    Province = "RS",
                    City = "Bergamota City",
                    Address = "Rua das Bergamotas"
                },
                ShippingPrice = result.Valor,
                TotalWeekdays = result.PrazoEntrega
            };

            return Ok(viewModel);
        }
    }
}
