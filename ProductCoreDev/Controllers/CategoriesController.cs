using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using ProductCoreDev.BaseController;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : EntityControllerBase<Categories, CategoriesReadModel, CategoriesCreateModel, CategoriesUpdateModel>
    {
        public CategoriesController(ProductdevContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Get(CancellationToken cancellationToken, Guid id)
        {
            var uri = new Uri( Request.GetEncodedUrl());
            var queryDictionary = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);
            var readModel = await ReadModel(id, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpGet("")]
        public async Task<ActionResult<IReadOnlyList<CategoriesReadModel>>> List(CancellationToken cancellationToken)
        {
            var listResult = await QueryModel(null, cancellationToken);
            return Ok(listResult);
        }

        [HttpPost("")]
        public async Task<ActionResult<CategoriesReadModel>> Create(CancellationToken cancellationToken, CategoriesCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken);

            return readModel;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Update(CancellationToken cancellationToken, Guid id, CategoriesUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Delete(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }
    }
}