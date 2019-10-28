using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Mapping;
using NesopsService.Domain.Models;
using NesopsService.Domain.Validation;
using NesopsService.Hook;
using NesopsService.Hook.Before;
using NesopsService.Hook.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NesopsService
{
    public static class ServiceRootConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {
            #region Auto Mapper Config
            // register AutoMapper profiles
            //services.AddAutoMapper(typeof(AspNetUsersProfile));
            services.AddAutoMapper(typeof(ProductsProfile).GetTypeInfo().Assembly);
            #endregion
            #region Config Validator
            // FluentValidation read on class extend AbstractValidator
            var types = typeof(CategoriesCreateModelValidator).Assembly.GetTypes();
            new AssemblyScanner(types).ForEach(pair => {
                services.Add(ServiceDescriptor.Transient(pair.InterfaceType, pair.ValidatorType));
            });
            #endregion

            //services.AddScoped(typeof(BeforeHookAspNetRoles));
            var typeHook = typeof(IHookBase);
            var typesHook = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeHook.IsAssignableFrom(p));
            foreach(Type type in typesHook)
            {
                if (type.Name.Contains("Before"))
                {
                    services.AddScoped(type);
                }
            }
        }
    }
}
