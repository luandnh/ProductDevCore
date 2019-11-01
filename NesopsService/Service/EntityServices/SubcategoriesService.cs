using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Service.BaseRepo;
using NesopsService.Service.Models.RequestModels;
using NesopsService.Service.ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesopsService.Service.EntityServices
{
    public class SubcategoriesService : BaseService<ProductdevContext, Subcategories, SubcategoriesReadModel, SubcategoriesCreateModel, SubcategoriesUpdateModel, SubcategoriesRequestModel>
    {
        public SubcategoriesService(IUnitOfWork<ProductdevContext> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
