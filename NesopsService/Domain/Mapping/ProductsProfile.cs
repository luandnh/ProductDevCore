using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class ProductsProfile
        : AutoMapper.Profile
    {
        public ProductsProfile()
        {
            CreateMap<NesopsService.Data.Entities.Products, NesopsService.Domain.Models.ProductsReadModel>();
            CreateMap<NesopsService.Domain.Models.ProductsCreateModel, NesopsService.Data.Entities.Products>();
            CreateMap<NesopsService.Data.Entities.Products, NesopsService.Domain.Models.ProductsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.ProductsUpdateModel, NesopsService.Data.Entities.Products>();
        }

    }
}
