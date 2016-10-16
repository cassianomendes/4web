using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FourWeb.Business.Identity.InputModels;
using FourWeb.Business.Identity.Domain.Services;
using AutoMapper;
using FourWeb.Abstraction.Domain.Entities;

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

        [HttpPost]
        public IActionResult Post(UserInputModel inputModel)
        {
            var user = _mapper.Map<User>(inputModel);
            _userService.Create(user);

            return Ok();
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            //to view model
            return Ok(_userService.GetById(id));
        }
    }
}
