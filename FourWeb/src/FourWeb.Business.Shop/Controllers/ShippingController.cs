using FourWeb.Business.Shop.InputModels;
using FourWeb.Business.Shop.ViewModels;
using FourWeb.ExternalServices.Correios;
using Microsoft.AspNetCore.Mvc;

namespace FourWeb.Business.Shop.Controllers
{
    [Route("api/[controller]")]
    public class ShippingController : Controller
    {
        private readonly CorreiosService _correiosService;

        public ShippingController(CorreiosService correiosService)
        {
            _correiosService = correiosService;
        }

        [HttpGet]
        public IActionResult Get([FromBody]ShippingInputModel inputModel)
        {
            // TODO: Chamar serviço de cálculo de frete
            var viewModel = new ShippingViewModel
            {
                Address = new ShippingAddressViewModel
                {
                    Province = "RS",
                    City = "Bergamota City",
                    Address = "Rua das Bergamotas"
                },
                ShippingPrice = 15,
                TotalWeekdays = 7
            };

            //_correiosService.CalculatePriceAndDeadline()

            return Ok(viewModel);
        }
    }
}
