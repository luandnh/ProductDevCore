using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetUserTokensProfile
        : AutoMapper.Profile
    {
        public AspNetUserTokensProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetUserTokens, NesopsService.Domain.Models.AspNetUserTokensReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserTokensCreateModel, NesopsService.Data.Entities.AspNetUserTokens>();
            CreateMap<NesopsService.Data.Entities.AspNetUserTokens, NesopsService.Domain.Models.AspNetUserTokensUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUserTokensUpdateModel, NesopsService.Data.Entities.AspNetUserTokens>();
        }

    }
}
