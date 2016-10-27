using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Identity.Domain.Services;
using FourWeb.Business.Identity.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Controllers
{   
    public class AuthorizationController : Controller
    {
        private readonly UserService _userService;

        public AuthorizationController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("~/connect/token")]        
        public IActionResult Exchange([FromBody] UserInputModel request)
        {
            var user =  _userService.GetByUsername(request.Email);
            if (user == null)
            {
                ModelState.AddModelError("User", "User not found");
                return BadRequest(ModelState);
            }
                
            if (!_userService.CheckPassword(user, request.Password))
            {
                ModelState.AddModelError("User", "Invalid password");
                return BadRequest(ModelState);
            }

            return CreateToken(user);
        }
        
        private IActionResult CreateToken(User user)
        {
            var token = $"{user.Id.ToString()}:{user.Email}";
            var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(token));

            return Ok(new { token = base64 });
        }
    }    
}
