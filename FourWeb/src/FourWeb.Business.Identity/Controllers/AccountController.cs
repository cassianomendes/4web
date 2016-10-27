using AutoMapper;
using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Identity.Domain.Services;
using FourWeb.Business.Identity.InputModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;                

        public AccountController(IMapper mapper, UserService userService)
        {
            _mapper = mapper;
            _userService = userService;            
        }
        
        [HttpPost]               
        public IActionResult Register([FromBody] UserInputModel model)
        {            
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(model);
                _userService.Create(user);                
                return Ok();
            }
                        
            return BadRequest(ModelState);
        }               
    }
}
