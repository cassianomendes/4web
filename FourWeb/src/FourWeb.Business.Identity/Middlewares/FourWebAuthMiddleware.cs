using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Identity.Domain.Services;
using FourWeb.Infrastructure.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Http.Features.Authentication;

namespace FourWeb.Business.Identity.Middlewares
{
    public class FourWebAuthMiddleware 
    {
        private readonly RequestDelegate _next;
        private UserService _userService;
        public FourWebAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, UserService userService)
        {
            _userService = userService;

            bool authenticated = await  Authenticate(context);

            if (authenticated) await _next.Invoke(context);
        }
        
        private async Task<bool> Authenticate(HttpContext context)
        {
            var requestPath = context.Request.Path.Value.ToLower();
            if (requestPath.Contains("/connect/token") 
                || requestPath.Contains("/account")) return true;

            var header = context.Request.Headers;
            if (!header.ContainsKey("Authorization")) return Unauthorized(context, "Header does not contains authorization key");

            var token = header["Authorization"].ToString();
            if (!token.Contains("Bearer")) return Unauthorized(context, "Header does not contains authorization bearer format");

            return await Authenticate(context, token);
        }

        private async Task<bool> Authenticate(HttpContext context, string token)
        {
            var bearer = token.Split(' ');
            if (bearer.Length < 2) return Unauthorized(context, "Invalid authorization format");

            var clear = Encoding.UTF8.GetString(Convert.FromBase64String(bearer[1]));
            
            var parts = clear.Split(':');
            if (parts.Length < 2) return Unauthorized(context, "Invalid bearer token format");

            var email = parts[1];

            var user = _userService.GetByUsername(email);
            if (user == null) return Unauthorized(context, "User has no access. Please register.");

            var principal = await context.Authentication.AuthenticateAsync(AuthenticationConstants.FourWebAuthenticationScheme);
        
            context.User = principal;

            return true;
        }

        private ClaimsPrincipal CreateClaimsPrincipal(User user)
        {
            return null;
        }

        private bool Unauthorized(HttpContext context, string error)
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            var message = Encoding.UTF8.GetBytes(error);
            context.Response.Body.Write(message, 0, message.Length);
            context.Response.Body.Flush();
            return false;
        }
    }
}
