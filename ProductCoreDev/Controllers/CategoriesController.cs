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
using NesopsService.Service.EntityServices;
using NesopsService.Service.Models.RequestModels;
using NesopsService.Service.Models.ResponseModels;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : EntityControllerBase<ProductdevContext, Categories, CategoriesReadModel, CategoriesCreateModel, CategoriesUpdateModel, CategoriesRequestModel, CategoriesService>
    {
        public CategoriesController(ProductdevContext dataContext, IMapper mapper, CategoriesService service) : base(dataContext, mapper, service)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetResponseModel<CategoriesReadModel, CategoriesRequestModel>>> Get(Guid id, [FromQuery]CategoriesRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { message = "Not found", code = 404 });
            return Ok(readModel);
        }

        [HttpGet("")]
        public async Task<ActionResult<GetResponseModel<CategoriesReadModel, CategoriesRequestModel>>> List([FromQuery]  CategoriesRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpPost("")]
        public async Task<ActionResult<CategoriesReadModel>> Create([FromForm]CategoriesCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(Get), new { id = readModel.Id }, readModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Update(CancellationToken cancellationToken, Guid id, CategoriesUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == default(CategoriesReadModel))
            {
                return NotFound(new BaseResponseModel<object> { message = "Not found", code = 404 });
            }
            return Ok(readModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriesReadModel>> Delete(CancellationToken cancellationToken, Guid id)
        {
            try
            {
                var result  = await DeleteModel(id, cancellationToken);
                if (result == default)
                {
                    return NotFound(new BaseResponseModel<object> { message = "Not found", code = 404 });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new BaseResponseModel<object> { message = ex.Message, code = 403 });
            }

            return Ok(new BaseResponseModel<object> { message = "Delete Successfully", code = 200 });
        }
    }
}