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
    public class BeforeHookCategories : HookHandleBase<Categories,CategoriesReadModel,CategoriesRequestModel>
    {
        public BeforeHookCategories(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

        public IQueryable<Categories> HandleRequestQuery(HttpRequest request)
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
        public async Task<List<CategoriesReadModel>> ListModel(HttpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = HandleRequestQuery(request);
            var result = new List<CategoriesReadModel>();
            var queryResult = await query.ToListAsync();
            result = _mapper.Map<List<CategoriesReadModel>>(queryResult);
            return result;
        }
        public async Task<CategoriesReadModel> ReadModel(HttpRequest request, Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = HandleRequestQuery(request);
            var queryResult = await CategoriesExtensions.GetByKeyAsync(query, id);
            var result = _mapper.Map<CategoriesReadModel>(queryResult);
            return result;
        }
    }
}
