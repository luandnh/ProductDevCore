using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetUserLoginsProfile
        : AutoMapper.Profile
    {
        public AspNetUserLoginsProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetUserLogins, NesopsService.Domain.Models.AspNetUserLoginsReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserLoginsCreateModel, NesopsService.Data.Entities.AspNetUserLogins>();
            CreateMap<NesopsService.Data.Entities.AspNetUserLogins, NesopsService.Domain.Models.AspNetUserLoginsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserLoginsUpdateModel, NesopsService.Data.Entities.AspNetUserLogins>();
        }

    }
}
