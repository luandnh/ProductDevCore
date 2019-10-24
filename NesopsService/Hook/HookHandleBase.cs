using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using NesopsService.Data;
using NesopsService.Hook.Models;
using NesopsService.Identifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesopsService.Hook
{
    public interface IHookHandleBase
    {
        ProductdevContext _dataContext { get; }
        IMapper _mapper { get; }
    }
    public class HookHandleBase<TEntity,TReadModel,TRequestModel> : IHookHandleBase 
        where TRequestModel : class, IRequestModelBase
        where TEntity : class,IHaveIdentifier
        where TReadModel : class
    {
        public ProductdevContext _dataContext { get; }
        public IMapper _mapper { get; }
        public HookHandleBase(ProductdevContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public virtual IQueryable<TEntity> HandleRequestQuery(HttpRequest request)
        {
            var query = _dataContext.Set<TEntity>().AsNoTracking();
            return query;
        }
        public virtual async Task<List<TReadModel>> ListModel(HttpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = HandleRequestQuery(request);
            var result = new List<TReadModel>();
            var queryResult = await query.ToListAsync();
            result = _mapper.Map<List<TReadModel>>(queryResult);
            return result;
        }
        public virtual async Task<TReadModel> ReadModel(HttpRequest request, Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = HandleRequestQuery(request);
            var queryResult = await query.FirstOrDefaultAsync(q => q.Id == id);
            var result = _mapper.Map<TReadModel>(queryResult);
            return result;
        }
    }
}
