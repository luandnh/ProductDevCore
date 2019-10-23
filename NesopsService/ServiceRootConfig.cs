using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NesopsService.Data;
using NesopsService.Domain.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService
{
    public static class ServiceRootConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {

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
        }
    }
}
