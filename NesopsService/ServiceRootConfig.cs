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
using System.Text;

namespace NesopsService
{
    public static class ServiceRootConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {
            #region Auto Mapper Config
            // register AutoMapper profiles
            services.AddAutoMapper(typeof(AspNetUsersProfile));
            services.AddAutoMapper(typeof(CategoriesProfile));
            services.AddAutoMapper(typeof(OptiongroupsProfile));
            services.AddAutoMapper(typeof(OptionsProfile));
            services.AddAutoMapper(typeof(OrderDetailProductOptionsProfile));
            services.AddAutoMapper(typeof(OrderDetailsProfile));
            services.AddAutoMapper(typeof(OrdersProfile));
            services.AddAutoMapper(typeof(ProductAttributesProfile));
            services.AddAutoMapper(typeof(ProductImagesProfile));
            services.AddAutoMapper(typeof(ProductOptionsProfile));
            services.AddAutoMapper(typeof(ProductsProfile));
            services.AddAutoMapper(typeof(ProductVideosProfile));
            services.AddAutoMapper(typeof(StoresProfile));
            services.AddAutoMapper(typeof(SubcategoriesProfile));
            #endregion
            #region Config Validator
            // FluentValidation read on class extend AbstractValidator
            var types = typeof(CategoriesCreateModelValidator).Assembly.GetTypes();
            new AssemblyScanner(types).ForEach(pair => {
                services.Add(ServiceDescriptor.Transient(pair.InterfaceType, pair.ValidatorType));
            });
            #endregion
            services.AddScoped(typeof(BeforeHookCategories));
            services.AddScoped(typeof(BeforeHookOptiongroups));
            services.AddScoped(typeof(BeforeHookOptions));
            services.AddScoped(typeof(BeforeHookOrderDetailProductOptions));
            services.AddScoped(typeof(BeforeHookOrderDetails));
            services.AddScoped(typeof(BeforeHookOrders));
            services.AddScoped(typeof(BeforeHookProductAttributes));
            services.AddScoped(typeof(BeforeHookProductImages));
            services.AddScoped(typeof(BeforeHookProductOptions));
            services.AddScoped(typeof(BeforeHookProducts));
            services.AddScoped(typeof(BeforeHookProductVideos));
            services.AddScoped(typeof(BeforeHookStores));
            services.AddScoped(typeof(BeforeHookSubcategories));
        }
    }
}
