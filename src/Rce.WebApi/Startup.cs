using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
//using Rce.Domain.Contextes;

namespace Rce.WebApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCaching();
            services.AddLocalization(options => options.ResourcesPath = "resources");

            // Add framework services.
            //var connection = @"Server=(localdb)\mssqllocaldb;Database=EF7.Rce;Trusted_Connection=True;";

            //services.AddEntityFramework()
            //    .AddSqlServer()
            //    .AddDbContext<RceDbContext>(options => options.UseSqlServer(connection));
  

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IMemoryCache cache)
        {
            AddLocalization(app);
            AddLocalMemoryCaching(app, cache);
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseIISPlatformHandler();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            app.UseStaticFiles();
            app.UseMvc();
        }

        private static void AddLocalization(IApplicationBuilder app)
        {
            var defaultCulture = new CultureInfo("en-US");
            var defaultRequestCulture = new RequestCulture(defaultCulture);
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("en-US"),
                new CultureInfo("et-ET")
            };
            var localizationOptions = new RequestLocalizationOptions
            {
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };

            app.UseRequestLocalization(localizationOptions, defaultRequestCulture);
        }


        private void AddLocalMemoryCaching(IApplicationBuilder app, IMemoryCache cache)
        {
            app.Map(new PathString("/set"), branch =>
            {
                branch.Run(async context =>
                {
                    foreach (var value in context.Request.Query)
                    {
                        cache.Set(value.Key, value.Value.First());
                    }

                    await context.Response.WriteAsync("<br>values set");
                });
            });
            app.Map(new PathString("/get"), branch =>
            {
                branch.Run(async context =>
                {
                    var keys = context.Request.Query["key"];

                    foreach (var key in keys)
                    {
                        var value = cache.Get(key) ?? "(not found)";
                        await context.Response.WriteAsync($"<br>{key} :: {value}");
                    }
                });
            });
            app.Map(new PathString("/del"), branch =>
            {
                branch.Run(async context =>
                {
                    var keys = context.Request.Query["key"];

                    foreach (var key in keys)
                    {
                        cache.Remove(key);
                    }

                    await context.Response.WriteAsync("<br>values removed");
                });
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
