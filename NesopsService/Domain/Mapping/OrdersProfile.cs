using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class OrdersProfile
        : AutoMapper.Profile
    {
        public OrdersProfile()
        {
            CreateMap<NesopsService.Data.Entities.Orders, NesopsService.Domain.Models.OrdersReadModel>();
            CreateMap<NesopsService.Domain.Models.OrdersCreateModel, NesopsService.Data.Entities.Orders>();
            CreateMap<NesopsService.Data.Entities.Orders, NesopsService.Domain.Models.OrdersUpdateModel>();
            CreateMap<NesopsService.Domain.Models.OrdersUpdateModel, NesopsService.Data.Entities.Orders>();
        }

    }
}
