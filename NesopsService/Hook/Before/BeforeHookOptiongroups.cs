using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Hook.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NesopsService.Hook.Before
{
    public class BeforeHookOptiongroups : HookHandleBase<ProductdevContext, Optiongroups, OptiongroupsReadModel, OptiongroupsRequestModel>
    {
        public BeforeHookOptiongroups(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

        /// <summary>
        /// Override Handle Query
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override IQueryable<Optiongroups> HandleRequestQuery(HttpRequest request)
        {
            var query = _dataContext.Optiongroups.AsNoTracking();
            var uri = new Uri(request.GetEncodedUrl());
            if (uri.Query != "")
            {
                var queryDictionary = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);
                if (queryDictionary.Count > 0)
                {
                    if (queryDictionary.ContainsKey("subcategories") && queryDictionary["subcategories"] == "1")
                    {
                        query = query.Include(p => p.OptionGroupOptions).AsQueryable();
                    }
                }
            }
            return query;
        }
    }
}
