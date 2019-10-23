using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesopsService.Services
{
    public class CategoriesService
    {
        protected ProductdevContext _dataContext { get; }
        protected IMapper _mapper { get; }
        public CategoriesService(ProductdevContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<CategoriesReadModel>> QueryModel(CancellationToken cancellationToken = default(CancellationToken), HttpRequest request = null)
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
            var resultSet = await query.ToListAsync();
            var result = _mapper.Map<List<Categories>, List<CategoriesReadModel>>(resultSet);
            return result;
        }
    }
}
