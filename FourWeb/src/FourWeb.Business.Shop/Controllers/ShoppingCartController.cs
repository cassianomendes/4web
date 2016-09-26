using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FourWeb.Business.Shop.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly IMapper _mapper;

        public ShoppingCartController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            /*
             TODO: Disponibiliza os dados de quantidade,
                   nome e preços do(s) item(ns) do
                   carrinho, assim como o valor total da
                   compra.
             */

            throw new NotImplementedException();
        }
    }
}
