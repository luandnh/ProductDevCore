using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Data.Queries;
using NesopsService.Domain.Models;
using NesopsService.Hook.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesopsService.Hook.Before
{
    public class BeforeHookCategories : HookHandleBase<ProductdevContext,Categories,CategoriesReadModel,CategoriesRequestModel>
    {
        public BeforeHookCategories(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

        /// <summary>
        /// Override Handle Query
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override IQueryable<Categories> HandleRequestQuery(HttpRequest request)
        {
            var query = _dataContext.Categories.AsNoTracking();
            var uri = new Uri(request.GetEncodedUrl());
            if (uri.Query != "")
            {
                var queryDictionary = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);
                if (queryDictionary.Count > 0)
                {
                    if (queryDictionary.ContainsKey("subcategories"))
                    {
                        query = query.Include(p => p.CategorySubcategories).AsQueryable();
                    }
                }
            }
            return query;
        }
    }
}
