using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Swashbuckle.AspNetCore;
using Microsoft.OpenApi.Models;
using NesopsService.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using NesopsService;
using ProductCoreDev.Filters;
using FluentValidation.AspNetCore;
using Nesops.Oauth2.Library;
using ProductCoreDev.Models;

namespace ProductCoreDev
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Authorize config
            NesopsAuthorizationConfig.Entry(services, Configuration);
            #endregion
            services.AddDbContext<ProductdevContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ProductDev")));
            #region Nesops Service
            ServiceRootConfig.Entry(services, Configuration);
            #endregion
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("nesops", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Nesops Swagger Production",
                    Description = "Nesops Swagger for Production Services",
                    Contact = new OpenApiContact
                    {
                        Name = "LuanDNH",
                        Email = "luandnh1998@gmail.com",
                        Url = new Uri("https://www.facebook.com/luandnh98")
                    },
                    TermsOfService = new Uri("http://nesops.xyz"),
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("http://nesops.xyz")
                    }
                }) ;
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference 
                            {
                                Type = ReferenceType.SecurityScheme, 
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddMvc(options => {
                options.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            #region Swagger Config
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/nesops/swagger.json", "Nesops Authorization");
                c.RoutePrefix = string.Empty;
            });
            #endregion
            app.UseCors(builder => builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
