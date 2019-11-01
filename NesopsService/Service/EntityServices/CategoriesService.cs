﻿using AutoMapper;
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
    public class CategoriesService : BaseService<ProductdevContext, Categories, CategoriesReadModel, CategoriesCreateModel, CategoriesUpdateModel, CategoriesRequestModel>
    {
        public CategoriesService(IUnitOfWork<ProductdevContext> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public override IQueryable<Categories> HandleRequest(CategoriesRequestModel requestModel)
        {
            var query = this.GetAllAsNoTracking();
            if (requestModel.relates.Contains("subcategories"))
            {
                query = query.Include(p => p.CategorySubcategories).AsQueryable();
            }
            return query;
        }
    }
}
