using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class SubcategoriesProfile
        : AutoMapper.Profile
    {
        public SubcategoriesProfile()
        {
            CreateMap<NesopsService.Data.Entities.Subcategories, NesopsService.Domain.Models.SubcategoriesReadModel>();
            CreateMap<NesopsService.Domain.Models.SubcategoriesCreateModel, NesopsService.Data.Entities.Subcategories>();
            CreateMap<NesopsService.Data.Entities.Subcategories, NesopsService.Domain.Models.SubcategoriesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.SubcategoriesUpdateModel, NesopsService.Data.Entities.Subcategories>();
        }

    }
}
