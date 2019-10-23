using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class AspNetUsersProfile
        : AutoMapper.Profile
    {
        public AspNetUsersProfile()
        {
            CreateMap<NesopsService.Data.Entities.AspNetUsers, NesopsService.Domain.Models.AspNetUsersReadModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUsersCreateModel, NesopsService.Data.Entities.AspNetUsers>();
            CreateMap<NesopsService.Data.Entities.AspNetUsers, NesopsService.Domain.Models.AspNetUsersUpdateModel>();
            CreateMap<NesopsService.Domain.Models.AspNetUsersUpdateModel, NesopsService.Data.Entities.AspNetUsers>();
        }

    }
}
