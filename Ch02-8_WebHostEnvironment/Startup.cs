using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Ch02_8_WebHostEnvironment
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async (context) =>
            {
                context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";

                if (env.IsEnvironment("Test")) // ���� ������ � ��������� "Test"
                {
                    await context.Response.WriteAsync("� ��������� ������������");
                }
                else
                {
                    await context.Response.WriteAsync("� �������� ���������� ��� � ����������");
                }
            });
        }
    }
}
