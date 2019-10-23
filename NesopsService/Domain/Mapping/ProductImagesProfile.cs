using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class ProductImagesProfile
        : AutoMapper.Profile
    {
        public ProductImagesProfile()
        {
            CreateMap<NesopsService.Data.Entities.ProductImages, NesopsService.Domain.Models.ProductImagesReadModel>();
            CreateMap<NesopsService.Domain.Models.ProductImagesCreateModel, NesopsService.Data.Entities.ProductImages>();
            CreateMap<NesopsService.Data.Entities.ProductImages, NesopsService.Domain.Models.ProductImagesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.ProductImagesUpdateModel, NesopsService.Data.Entities.ProductImages>();
        }

    }
}
