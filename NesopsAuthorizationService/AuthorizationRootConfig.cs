using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NesopsAuthorizationService.DBContext;
using NesopsAuthorizationService.Identity;
using NesopsAuthorizationService.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService
{
    public static class AuthorizationRootConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration, IdentityOptions identityOptions)
        {
            //services.AddDbContext<NesopsIdentityDbContext>(options=>options.UseMySql(configuration.GetConnectionString("AuthorizeDB")));
            services.AddDbContext<NesopsIdentityDbContext>(options=>options.UseSqlServer(configuration.GetConnectionString("ProductDev")));
            services.AddScoped(typeof(NesopsIdentityDbContext));
            services.AddScoped(typeof(AuthorizationService));
            services.AddScoped(typeof(NesopsUserManager));
            AMC.Configure();
            services.AddIdentityCore<NesopsUser>(config=>
            {
                identityOptions = config;
                config.SignIn.RequireConfirmedEmail = false;
            }).AddRoles<NesopsRole>()
                .AddEntityFrameworkStores<NesopsIdentityDbContext>();
            services.AddHttpContextAccessor();
            services.AddScoped(typeof(SignInManager<NesopsUser>));
            #region Password and User config
            services.Configure<IdentityOptions>(options => {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 0;
                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;
                // User 
                options.User.AllowedUserNameCharacters ="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
            #endregion
            #region Jwt Config
            const string scheme = JwtBearerDefaults.AuthenticationScheme;
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = scheme;
                    options.DefaultChallengeScheme = scheme;
                    options.DefaultScheme = scheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = NesopsJwtConfiguration.Nesops_Audience,
                        ValidIssuer = NesopsJwtConfiguration.Nesops_Issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(NesopsJwtConfiguration.Nesops_SecretKey))
                    };
                });
            #endregion
        }
    }
}
