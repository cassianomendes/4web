using AutoMapper;
using FourWeb.Business.Shop.Domain.Entities;
using FourWeb.Business.Shop.Domain.Services;
using FourWeb.Business.Shop.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Shop.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        private readonly AddressService _addressService;
        private readonly PaymentMethodService _paymentMethodService;
        private readonly IMapper _mapper;

        public OrderController
        (
            OrderService orderService, 
            AddressService addressService, 
            PaymentMethodService paymentMethodService,
            IMapper mapper
        )
        {
            _orderService = orderService;
            _addressService = addressService;
            _paymentMethodService = paymentMethodService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderInputModel inputModel)
        {            
            var paymentMethod = _paymentMethodService.GetById(inputModel.PaymentMethodId);
            var payment = _mapper.Map<CreditCard>(inputModel.CreditCard) ?? BankSlip.Create() as Payment;
            var address = _addressService.GetById(inputModel.AddressId);

            _orderService.ProcessOrder(User.Identity.Name, paymentMethod, payment, address, inputModel.CouponCode);

            return Ok();
        }
    }
}
