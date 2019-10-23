using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetUserClaimsProfile
        : AutoMapper.Profile
    {
        public AspNetUserClaimsProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetUserClaims, NesopsService.Domain.Models.AspNetUserClaimsReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserClaimsCreateModel, NesopsService.Data.Entities.AspNetUserClaims>();
            CreateMap<NesopsService.Data.Entities.AspNetUserClaims, NesopsService.Domain.Models.AspNetUserClaimsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserClaimsUpdateModel, NesopsService.Data.Entities.AspNetUserClaims>();
        }

    }
}
