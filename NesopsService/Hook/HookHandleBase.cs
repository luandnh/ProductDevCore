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
    public interface IHookHandleBase<TDBContext, TEntity, TReadModel, TRequestModel> 
        where TDBContext : DbContext
        where TRequestModel : class, IRequestModelBase
        where TEntity : class, IHaveIdentifier
        where TReadModel : class
    {
        TDBContext _dataContext { get; }
        IMapper _mapper { get; }
        Task<List<TReadModel>> ListModel(HttpRequest request, CancellationToken cancellationToken = default(CancellationToken));
        Task<TReadModel> ReadModel(HttpRequest request, Guid id, CancellationToken cancellationToken = default(CancellationToken));
    }
    public class HookHandleBase<TDBContext, TEntity,TReadModel,TRequestModel> : IHookHandleBase<TDBContext, TEntity, TReadModel, TRequestModel>
        where TDBContext : DbContext
        where TRequestModel : class, IRequestModelBase
        where TEntity : class,IHaveIdentifier
        where TReadModel : class
    {
        public TDBContext _dataContext { get; }
        public IMapper _mapper { get; }
        public HookHandleBase(TDBContext dataContext, IMapper mapper)
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
