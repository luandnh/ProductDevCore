using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetRolesProfile
        : AutoMapper.Profile
    {
        public AspNetRolesProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetRoles, NesopsService.Domain.Models.AspNetRolesReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetRolesCreateModel, NesopsService.Data.Entities.AspNetRoles>();
            CreateMap<NesopsService.Data.Entities.AspNetRoles, NesopsService.Domain.Models.AspNetRolesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetRolesUpdateModel, NesopsService.Data.Entities.AspNetRoles>();
        }

    }
}
