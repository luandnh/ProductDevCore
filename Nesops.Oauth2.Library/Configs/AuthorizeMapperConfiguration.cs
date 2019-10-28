using AutoMapper;
using Nesops.Oauth2.Library.Models;
using Nesops.Oauth2.Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library.Configs
{
    /// <summary>
    /// AuthorizationMapperConfiguration ( AMC )
    /// </summary>
    public static partial class AMC
    {
        public  static IMapper _mapper { get; set; }
        private static void ConfigureAutoMapper()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<NesopsRoles, NesopsRolesViewModel>().ReverseMap();
            });
            AMC._mapper = mapperConfig.CreateMapper();
        }
        public static void Configure()
        {
            ConfigureAutoMapper();
        }
    }
}
