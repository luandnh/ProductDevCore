using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetRoleClaimsProfile
        : AutoMapper.Profile
    {
        public AspNetRoleClaimsProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetRoleClaims, NesopsService.Domain.Models.AspNetRoleClaimsReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetRoleClaimsCreateModel, NesopsService.Data.Entities.AspNetRoleClaims>();
            CreateMap<NesopsService.Data.Entities.AspNetRoleClaims, NesopsService.Domain.Models.AspNetRoleClaimsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetRoleClaimsUpdateModel, NesopsService.Data.Entities.AspNetRoleClaims>();
        }

    }
}
