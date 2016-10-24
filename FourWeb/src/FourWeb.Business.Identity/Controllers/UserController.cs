using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FourWeb.Business.Identity.InputModels;
using FourWeb.Business.Identity.Domain.Services;
using AutoMapper;
using FourWeb.Abstraction.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using FourWeb.Infrastructure.Constants;

namespace FourWeb.Business.Identity.Controllers
{
    [Route("api/[controller]")]    
    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;
        public UserController(IMapper mapper, UserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var user = User;

            return Ok(_userService.GetById(id));
        }
    }
}
