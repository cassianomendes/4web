using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Business.Identity.Domain.Services;
using FourWeb.Infrastructure.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Middlewares
{
    public class FourWebAuthMiddleware 
    {
        private readonly RequestDelegate _next;
        private readonly IAuthorizationService _authorization;
        private UserService _userService;
        public FourWebAuthMiddleware(RequestDelegate next, IAuthorizationService authorization)
        {
            _authorization = authorization;
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

            context.User = CreateClaimsPrincipal(user);

            return await _authorization.AuthorizeAsync(context.User, AuthenticationConstants.FourWebAuthenticationPolicy);            
        }

        private ClaimsPrincipal CreateClaimsPrincipal(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.Email),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Email),
                new Claim(ClaimTypes.Upn, user.Id.ToString())
            };
            var identity = new ClaimsIdentity(claims, "Password");
            //identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.GivenName, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.Name, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.Upn, user.Id.ToString()));
            var principal = new ClaimsPrincipal(identity);

            return principal;
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
