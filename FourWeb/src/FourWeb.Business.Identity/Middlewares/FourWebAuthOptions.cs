using FourWeb.Infrastructure.Constants;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Middlewares
{
    public class FourWebAuthOptions : AuthenticationOptions
    {
        public FourWebAuthOptions()            
        {
            AuthenticationScheme = AuthenticationConstants.FourWebAuthenticationScheme;
        }
    }
}
