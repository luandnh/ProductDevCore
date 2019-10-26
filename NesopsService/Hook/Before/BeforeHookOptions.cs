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
    public class BeforeHookOptions : HookHandleBase<ProductdevContext, Options, OptionsReadModel, OptionsRequestModel>
    {
        public BeforeHookOptions(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
    }
}
