using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Report.Controllers
{
    [Route("api/report/[controller]")]
    public class OrderController : Controller
    {
        public OrderController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            // TODO: Lista com todos os pedidos
            return Ok();
        }

        [Route("latest")]
        [HttpGet]
        public IActionResult GetLatestOrders()
        {
            // TODO: Lista com os 3 últimos pedidos
            return Ok();
        }

        [Route("date")]
        [HttpGet]
        public IActionResult GetByDate()
        {
            // TODO: Lista com os pedidos da data
            return Ok();
        }

        [Route("{id:int}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            // TODO: Detalhes do pedido fornecido pelo usuário
            return Ok();
        }
    }
}
