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
using NesopsService.EntityControllerBase;
using NesopsService.Hook.Before;
using NesopsService.Hook.Models.RequestModels;
using NesopsService.Hook.Models.ResponseModels;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : EntityControllerBase<ProductdevContext, Categories, CategoriesReadModel, CategoriesCreateModel, CategoriesUpdateModel, CategoriesRequestModel, BeforeHookCategories>
    {
        public CategoriesController(ProductdevContext dataContext, IMapper mapper, BeforeHookCategories hook) : base(dataContext, mapper, hook)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetResponseModel<CategoriesReadModel, CategoriesRequestModel>>> Get(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await ReadModel(this.Request, id, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });
            return Ok(readModel);
        }

        [HttpGet("")]
        public async Task<ActionResult<GetResponseModel<CategoriesReadModel, CategoriesRequestModel>>> List(CancellationToken cancellationToken, [FromQuery]  CategoriesRequestModel requestModel)
        {
            var readModels = await ListModel(this.Request, requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpPost("")]
        public async Task<ActionResult<CategoriesReadModel>> Create(CancellationToken cancellationToken,[FromForm]CategoriesCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(Get), new { id = readModel.Id });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Update(CancellationToken cancellationToken, Guid id, CategoriesUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });

            return Ok(readModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Delete(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });

            return Ok(readModel);
        }
    }
}