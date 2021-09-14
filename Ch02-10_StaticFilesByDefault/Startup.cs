using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch02_10_StaticFilesByDefault
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear(); // ������� ����� ������ �� ���������
            options.DefaultFileNames.Add("hello.html"); // ��������� ����� ��� �����
            app.UseDefaultFiles(options); // 
            //app.UseDefaultFiles(); // ��������� �������� �� ��������� 
            
            app.UseStaticFiles(); // ��������� ����������� �����

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        }
    }
}
