using AutoMapper;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Hook.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Hook.Before
{
    public class BeforeHookProductAttributes : HookHandleBase<ProductdevContext, ProductAttributes, ProductAttributesReadModel, ProductAttributesRequestModel>
    {
        public BeforeHookProductAttributes(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
    }
}
