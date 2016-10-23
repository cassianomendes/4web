using AutoMapper;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Services;
using FourWeb.Business.Shop.InputModels;
using FourWeb.Business.Shop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourWeb.Business.Shop.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCartService _service;
        private readonly IMapper _mapper;

        public ShoppingCartController(ShoppingCartService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var shoppingCart = _service.GetByCustomer(User.Identity.Name);
            var viewModel = _mapper.Map<ShoppingCartViewModel>(shoppingCart);
            return Ok(viewModel);
        }

        [HttpPost]
        public IActionResult Post([FromBody]ShoppingCartItemInputModel inputModel)
        {
            var item = _mapper.Map<ShoppingCartItem>(inputModel);
            _service.AddItem(User.Identity.Name, item);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody]ShoppingCartItemInputModel inputModel)
        {
            var item = _mapper.Map<ShoppingCartItem>(inputModel);
            _service.UpdateItemQuantity(User.Identity.Name, item);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] int productId)
        {
            _service.DeleteItem(User.Identity.Name, productId);
            return Ok();
        }
    }
}
