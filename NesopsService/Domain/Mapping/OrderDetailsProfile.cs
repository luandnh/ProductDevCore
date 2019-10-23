using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class OrderDetailsProfile
        : AutoMapper.Profile
    {
        public OrderDetailsProfile()
        {
            CreateMap<NesopsService.Data.Entities.OrderDetails, NesopsService.Domain.Models.OrderDetailsReadModel>();
            CreateMap<NesopsService.Domain.Models.OrderDetailsCreateModel, NesopsService.Data.Entities.OrderDetails>();
            CreateMap<NesopsService.Data.Entities.OrderDetails, NesopsService.Domain.Models.OrderDetailsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.OrderDetailsUpdateModel, NesopsService.Data.Entities.OrderDetails>();
        }

    }
}
