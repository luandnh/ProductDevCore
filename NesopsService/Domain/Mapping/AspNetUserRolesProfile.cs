using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetUserRolesProfile
        : AutoMapper.Profile
    {
        public AspNetUserRolesProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetUserRoles, NesopsService.Domain.Models.AspNetUserRolesReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserRolesCreateModel, NesopsService.Data.Entities.AspNetUserRoles>();
            CreateMap<NesopsService.Data.Entities.AspNetUserRoles, NesopsService.Domain.Models.AspNetUserRolesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserRolesUpdateModel, NesopsService.Data.Entities.AspNetUserRoles>();
        }

    }
}
