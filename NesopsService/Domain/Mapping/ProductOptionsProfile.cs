using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class ProductOptionsProfile
        : AutoMapper.Profile
    {
        public ProductOptionsProfile()
        {
            CreateMap<NesopsService.Data.Entities.ProductOptions, NesopsService.Domain.Models.ProductOptionsReadModel>();
            CreateMap<NesopsService.Domain.Models.ProductOptionsCreateModel, NesopsService.Data.Entities.ProductOptions>();
            CreateMap<NesopsService.Data.Entities.ProductOptions, NesopsService.Domain.Models.ProductOptionsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.ProductOptionsUpdateModel, NesopsService.Data.Entities.ProductOptions>();
        }

    }
}
