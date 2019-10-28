using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Nesops.Oauth2.Library.Configs;
using Nesops.Oauth2.Library.DataContext;
using Nesops.Oauth2.Library.Models;
using Nesops.Oauth2.Library.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library
{
    public static class NesopsAuthorizationConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NesopsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ProductDev")));
            services.AddScoped(typeof(DbContext),typeof(NesopsDbContext));
            services.AddScoped(typeof(NesopsUserManager));
            services.AddScoped(typeof(AuthorizationService));
            services.AddIdentity<NesopsUsers, NesopsRoles>()
                .AddEntityFrameworkStores<NesopsDbContext>();
            services.AddHttpContextAccessor();
            services.AddScoped(typeof(SignInManager<NesopsUsers>));
            JWTBuilder.BuildJWTService(services);
            AMC.Configure();
        }
    }
}
