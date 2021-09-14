using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch02_6_CustomMiddlewarePrimitive
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.UseMiddleware<TokenMiddleware>();
            app.UseToken();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        }
    }
}
