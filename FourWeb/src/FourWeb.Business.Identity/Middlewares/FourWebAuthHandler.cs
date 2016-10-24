using FourWeb.Infrastructure.Constants;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Middlewares
{
    public class FourWebAuthHandler : AuthenticationHandler<FourWebAuthOptions>
    {
        public FourWebAuthHandler()
            : base()
        {

        }
        
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var identity = new ClaimsIdentity();
            //identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.GivenName, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Email));
            //identity.AddClaim(new Claim(ClaimTypes.Upn, user.Id.ToString()));

            var principal = new ClaimsPrincipal(identity);

            var result = AuthenticateResult.Success(new AuthenticationTicket(principal, new AuthenticationProperties(), AuthenticationConstants.FourWebAuthenticationScheme));

            return Task.FromResult(result);
        }
    }
}
