using AutoMapper;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Services;
using FourWeb.Business.Shop.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FourWeb.Business.Shop.Controllers
{
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
            // TODO: Informar o usuário por parâmetro.
            return Ok(_service.Get(-1));
        }

        [HttpPost]
        public IActionResult Post([FromBody]ShoppingCartItemInputModel inputModel)
        {
            var item = _mapper.Map<ShoppingCartItem>(inputModel);
            throw new NotImplementedException();
        }


    }
}
