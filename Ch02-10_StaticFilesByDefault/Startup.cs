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
            options.DefaultFileNames.Clear(); // удаляем имена файлов по умолчанию
            options.DefaultFileNames.Add("hello.html"); // добавляем новое имя файла
            app.UseDefaultFiles(options); // 
            //app.UseDefaultFiles(); // Разрешить страницы по умолчанию 
            
            app.UseStaticFiles(); // Разрешить статические файлы

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        }
    }
}
