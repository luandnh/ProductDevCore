using AutoMapper;
using NesopsService.Data;
using NesopsService.Hook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesopsService.Hook
{
    public interface IHookHandleBase
    {
        ProductdevContext _dataContext { get; }
        IMapper _mapper { get; }
    }
    public class HookHandleBase<TEntity,TReadModel,TRequestModel> : IHookHandleBase where TRequestModel : class, IRequestModelBase
    {
        public ProductdevContext _dataContext { get; }
        public IMapper _mapper { get; }
        public HookHandleBase(ProductdevContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
    }
}
