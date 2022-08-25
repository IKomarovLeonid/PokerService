﻿using System;
using System.IO;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;

namespace API.Src
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddMvcCore(options => options.EnableEndpointRouting = false)
                .AddNewtonsoftJson(o =>
                {
                    o.SerializerSettings.Converters.Add(new StringEnumConverter());
                })
                .AddApiExplorer();

            services.AddSwaggerDocument(settings =>
            {
                settings.SchemaType = NJsonSchema.SchemaType.OpenApi3;
                settings.AllowReferencesWithProperties = true;
                settings.Title = "Tasks-Platform";
            });

            var builder = AutofacBuilder.Build();

            builder.Populate(services);
            return new AutofacServiceProvider(builder.Build());
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCors(_ => _.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin());

            app.UseMvcWithDefaultRoute();

            app.UseOpenApi().UseSwaggerUi3();

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            app.UseDefaultFiles(new DefaultFilesOptions()
            {
                FileProvider = new PhysicalFileProvider(path),
                RequestPath = new PathString("")
            });

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(path),
                RequestPath = new PathString("")
            });
        }
    }
}
