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
    public class BeforeHookOptiongroups : HookHandleBase<ProductdevContext, Optiongroups, OptiongroupsCreateModel, OptiongroupsRequestModel>
    {
        public BeforeHookOptiongroups(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
    }
}
