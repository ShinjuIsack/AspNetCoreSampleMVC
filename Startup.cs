using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebApplication
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)// dependency injection
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //DefaultFilesOptions defFileOptions = new DefaultFilesOptions();
            //defFileOptions.DefaultFileNames.Clear();
            //defFileOptions.DefaultFileNames.Add("Sample.html");
            //app.UseDefaultFiles(defFileOptions);
            //app.UseDefaultFiles();
            //app.UseStaticFiles();
            //app.UseFileServer();

            //1. Show Default.html while taking root of the project (http://localhost:4147/)

            // app.UseDefaultFiles();
            //app.UseStaticFiles();

            //OR instd of using UseDefaultFiles, and UseStaticFiles middleware use as below
            //app.UseFileServer();

            //2. Show Sample.html while taking root of the project (http://localhost:4147/)
            //DefaultFilesOptions defFileOptions = new DefaultFilesOptions();
            //defFileOptions.DefaultFileNames.Clear();
            //defFileOptions.DefaultFileNames.Add("Sample.html");
            //app.UseDefaultFiles(defFileOptions);

            //Another method
            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("Sample.html");
            //app.UseFileServer(fileServerOptions);

            //app.UseFileServer();
            app.UseRouting();

            //DefaultFilesOptions defFileOptions = new DefaultFilesOptions();
            //defFileOptions.DefaultFileNames.Clear();
            //defFileOptions.DefaultFileNames.Add("Sample.html");
            //app.UseDefaultFiles(defFileOptions);
            /* app.Use(async (context, next) =>
             {
                 await context.Response.WriteAsync("Hello from 1st MW ");
                 await next();
                 await context.Response.WriteAsync("Hello from 1st MW response ");
             });

             app.Use(async (context, next) =>
             {
                 await context.Response.WriteAsync("Hello from 2nd MW ");
                 await next();
                 await context.Response.WriteAsync("Hello from 2nd MW response ");

             });
             app.Use(async (context, next) =>
             {
                 await context.Response.WriteAsync("Hello from 3rd MW ");
                 await next();
                 await context.Response.WriteAsync("Hello from 3rd MW  response ");
             }
                 );*/
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    //throw new Exception("Some error has happened");
                //    await context.Response.WriteAsync("Hello World!");
                //    //await context.Response
                //    //.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);//Outputs iisexpress with <AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
                //    //await context.Response.WriteAsync(_config["MyKey"]);
                //});
                endpoints.MapDefaultControllerRoute();
            });


        }
    }
}
