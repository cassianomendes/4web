using AutoMapper;
using FourWeb.Business.Report.Domain.Services;
using FourWeb.Business.Report.InputModels;
using FourWeb.Business.Report.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FourWeb.Business.Report.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(OrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var orders = _orderService.GetAll(User.Identity.Name);
            var viewModel = _mapper.Map<IEnumerable<OrderViewModel>>(orders);
            return Ok(viewModel);
        }

        [Route("latest")]
        [HttpGet]
        public IActionResult GetLatestOrders()
        {
            var orders = _orderService.GetLatestOrders(User.Identity.Name);
            var viewModel = _mapper.Map<IEnumerable<OrderViewModel>>(orders);
            return Ok(viewModel);
        }

        [Route("date")]
        [HttpGet]
        public IActionResult GetByDate([FromBody] OrderByDateInputModel inputModel)
        {
            var orders = _orderService.GetByDate(User.Identity.Name, inputModel.Date);
            var viewModel = _mapper.Map<IEnumerable<OrderViewModel>>(orders);
            return Ok(viewModel);
        }

        [Route("{id:int}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var order = _orderService.GetById(id);
            var viewModel = _mapper.Map<OrderDetailViewModel>(order);
            return Ok(viewModel);
        }
    }
}
