using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class OrderDetailProductOptionsProfile
        : AutoMapper.Profile
    {
        public OrderDetailProductOptionsProfile()
        {
            CreateMap<NesopsService.Data.Entities.OrderDetailProductOptions, NesopsService.Domain.Models.OrderDetailProductOptionsReadModel>();
            CreateMap<NesopsService.Domain.Models.OrderDetailProductOptionsCreateModel, NesopsService.Data.Entities.OrderDetailProductOptions>();
            CreateMap<NesopsService.Data.Entities.OrderDetailProductOptions, NesopsService.Domain.Models.OrderDetailProductOptionsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.OrderDetailProductOptionsUpdateModel, NesopsService.Data.Entities.OrderDetailProductOptions>();
        }

    }
}
