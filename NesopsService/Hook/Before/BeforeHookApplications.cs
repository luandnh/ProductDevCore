using AutoMapper;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Hook.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NesopsService.Hook.Before
{
    public class BeforeHookApplications : HookHandleBase<ProductdevContext, Applications, ApplicationsReadModel, ApplicationsRequestModel>
    {
        public BeforeHookApplications(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
        public bool IsValidRedirectUrl(string url)
        {
            if (url.Equals("/"))
                return true;
            var uri = new Uri(url);
            url = uri.AbsoluteUri;
            var allUrlLists = _dataContext.Applications.Select(app => app.RedirectUrl).ToList();
            return allUrlLists.Contains(url);
        }
    }
}
