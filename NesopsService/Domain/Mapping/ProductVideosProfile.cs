using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class ProductVideosProfile
        : AutoMapper.Profile
    {
        public ProductVideosProfile()
        {
            CreateMap<NesopsService.Data.Entities.ProductVideos, NesopsService.Domain.Models.ProductVideosReadModel>();
            CreateMap<NesopsService.Domain.Models.ProductVideosCreateModel, NesopsService.Data.Entities.ProductVideos>();
            CreateMap<NesopsService.Data.Entities.ProductVideos, NesopsService.Domain.Models.ProductVideosUpdateModel>();
            CreateMap<NesopsService.Domain.Models.ProductVideosUpdateModel, NesopsService.Data.Entities.ProductVideos>();
        }

    }
}
