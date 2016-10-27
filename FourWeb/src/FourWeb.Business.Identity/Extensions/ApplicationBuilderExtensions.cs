using FourWeb.Business.Identity.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseFourWebAuth(this IApplicationBuilder app)
        {
            app.UseMiddleware<FourWebAuthMiddleware>();
        }
    }
}
