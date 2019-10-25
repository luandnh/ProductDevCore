using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NesopsService.Data;
using NesopsService.Hook;
using NesopsService.Hook.Models;
using NesopsService.Hook.Models.ResponseModels;
using NesopsService.Identifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace NesopsService.EntityControllerBase
{
    public interface IEntityControllerBase<TEntity, TReadModel, TCreateModel, TUpdateModel, TRequestModel>
        where TEntity : class, IHaveIdentifier
        where TRequestModel : class, IRequestModelBase
        where TReadModel : class
    {
        Task<GetResponseModel<TReadModel, TRequestModel>> ReadModel(HttpRequest request, Guid id, CancellationToken cancellationToken = default(CancellationToken));
        Task<GetResponseModel<TReadModel, TRequestModel>> ListModel(HttpRequest request, TRequestModel requestModel, CancellationToken cancellationToken = default(CancellationToken));
        Task<TReadModel> CreateModel(TCreateModel createModel, CancellationToken cancellationToken = default(CancellationToken));
        Task<TReadModel> UpdateModel(Guid id, TUpdateModel updateModel, CancellationToken cancellationToken = default(CancellationToken));
        Task<TReadModel> DeleteModel(Guid id, CancellationToken cancellationToken = default(CancellationToken));
    }
    [ApiController]
    [Produces("application/json")]
    public abstract class EntityControllerBase<TDBContext, TEntity, TReadModel, TCreateModel, TUpdateModel, TRequestModel, THook> : ControllerBase,IEntityControllerBase<TEntity, TReadModel, TCreateModel, TUpdateModel, TRequestModel>
        where TDBContext : DbContext    
        where TEntity : class, IHaveIdentifier
        where TRequestModel : class, IRequestModelBase
        where TReadModel : class
        where THook : class, IHookHandleBase<TDBContext, TEntity, TReadModel, TRequestModel>
    {
        protected TDBContext _dataContext { get; }
        protected IMapper _mapper { get; }
        protected THook _hook { get; set; }

        protected EntityControllerBase(TDBContext dataContext, IMapper mapper, THook hook)
        {
            _dataContext = dataContext;
            _mapper = mapper;
            _hook = hook;
        }
        public virtual async Task<GetResponseModel<TReadModel,TRequestModel>> ReadModel(HttpRequest request, Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var readModel = await _hook.ReadModel(request, id, cancellationToken);
            if (readModel == null)
            {
                return null;
            }
            var result = new GetResponseModel<TReadModel, TRequestModel>(readModel);
            return result;
        }
        public virtual async Task<GetResponseModel<TReadModel, TRequestModel>> ListModel(HttpRequest request,TRequestModel requestModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var readModel = await _hook.ListModel(request, cancellationToken);
            if (readModel == null)
            {
                return null;
            }
            var result = new GetResponseModel<TReadModel, TRequestModel>(readModel, requestModel);
            return result;
        }
        public virtual async Task<TReadModel> CreateModel(TCreateModel createModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            // create new entity from model
            var entity = _mapper.Map<TEntity>(createModel);

            // add to data set, id should be generated
            await _dataContext
                .Set<TEntity>()
                .AddAsync(entity, cancellationToken);

            // save to database
            await _dataContext
                .SaveChangesAsync(cancellationToken);

            // convert to read model
            var readModel = await ReadModel(entity.Id, cancellationToken);

            return readModel;
        }

        public virtual async Task<TReadModel> UpdateModel(Guid id, TUpdateModel updateModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await _dataContext
                .Set<TEntity>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
                return default(TReadModel);

            // copy updates from model to entity
            _mapper.Map(updateModel, entity);

            // save updates
            await _dataContext
                .SaveChangesAsync(cancellationToken);

            // return read model
            var readModel = await ReadModel(id, cancellationToken);
            return readModel;
        }

        public virtual async Task<TReadModel> DeleteModel(Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var dbSet = _dataContext
                .Set<TEntity>();

            var keyValue = new object[] { id };

            // find entity to delete by id
            var entity = await dbSet
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
                return default(TReadModel);

            // return read model
            var readModel = await ReadModel(id, cancellationToken);

            // delete entry
            dbSet.Remove(entity);

            // save 
            await _dataContext
                .SaveChangesAsync(cancellationToken);

            return readModel;
        }
        private async Task<TReadModel> ReadModel(Guid id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var model = await _dataContext
                .Set<TEntity>()
                .AsNoTracking()
                .Where(p => p.Id == id)
                .ProjectTo<TReadModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);

            return model;
        }
    }
}
