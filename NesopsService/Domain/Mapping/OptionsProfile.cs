using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class OptionsProfile
        : AutoMapper.Profile
    {
        public OptionsProfile()
        {
            CreateMap<NesopsService.Data.Entities.Options, NesopsService.Domain.Models.OptionsReadModel>();
            CreateMap<NesopsService.Domain.Models.OptionsCreateModel, NesopsService.Data.Entities.Options>();
            CreateMap<NesopsService.Data.Entities.Options, NesopsService.Domain.Models.OptionsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.OptionsUpdateModel, NesopsService.Data.Entities.Options>();
        }

    }
}
