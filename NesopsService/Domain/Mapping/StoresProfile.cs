using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class StoresProfile
        : AutoMapper.Profile
    {
        public StoresProfile()
        {
            CreateMap<NesopsService.Data.Entities.Stores, NesopsService.Domain.Models.StoresReadModel>();
            CreateMap<NesopsService.Domain.Models.StoresCreateModel, NesopsService.Data.Entities.Stores>();
            CreateMap<NesopsService.Data.Entities.Stores, NesopsService.Domain.Models.StoresUpdateModel>();
            CreateMap<NesopsService.Domain.Models.StoresUpdateModel, NesopsService.Data.Entities.Stores>();
        }

    }
}
