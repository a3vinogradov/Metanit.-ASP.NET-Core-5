using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        //app.UseDirectoryBrowser();
        //или
        app.UseDirectoryBrowser(new DirectoryBrowserOptions()
        {
            FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images")),

            RequestPath = new PathString("/pages")
        });
        app.UseStaticFiles();
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World");
        });
    }
}
