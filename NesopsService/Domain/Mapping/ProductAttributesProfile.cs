using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class ProductAttributesProfile
        : AutoMapper.Profile
    {
        public ProductAttributesProfile()
        {
            CreateMap<NesopsService.Data.Entities.ProductAttributes, NesopsService.Domain.Models.ProductAttributesReadModel>();
            CreateMap<NesopsService.Domain.Models.ProductAttributesCreateModel, NesopsService.Data.Entities.ProductAttributes>();
            CreateMap<NesopsService.Data.Entities.ProductAttributes, NesopsService.Domain.Models.ProductAttributesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.ProductAttributesUpdateModel, NesopsService.Data.Entities.ProductAttributes>();
        }

    }
}
