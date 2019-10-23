using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CategoriesProfile
        : AutoMapper.Profile
    {
        public CategoriesProfile()
        {
            CreateMap<NesopsService.Data.Entities.Categories, NesopsService.Domain.Models.CategoriesReadModel>();
            CreateMap<NesopsService.Domain.Models.CategoriesCreateModel, NesopsService.Data.Entities.Categories>();
            CreateMap<NesopsService.Data.Entities.Categories, NesopsService.Domain.Models.CategoriesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CategoriesUpdateModel, NesopsService.Data.Entities.Categories>();
        }

    }
}
