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
    public class OrderDetailProductOptionsController : EntityControllerBase<ProductdevContext, OrderDetailProductOptions, OrderDetailProductOptionsReadModel, OrderDetailProductOptionsCreateModel, OrderDetailProductOptionsUpdateModel, OrderDetailProductOptionsRequestModel, BeforeHookOrderDetailProductOptions>
    {
        public OrderDetailProductOptionsController(ProductdevContext dataContext, IMapper mapper, BeforeHookOrderDetailProductOptions hook) : base(dataContext, mapper, hook)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetResponseModel<OrderDetailProductOptionsReadModel, OrderDetailProductOptionsRequestModel>>> Get(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await ReadModel(this.Request, id, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });
            return Ok(readModel);
        }

        [HttpGet("")]
        public async Task<ActionResult<GetResponseModel<OrderDetailProductOptionsReadModel, OrderDetailProductOptionsRequestModel>>> List(CancellationToken cancellationToken, [FromQuery]  OrderDetailProductOptionsRequestModel requestModel)
        {
            var readModels = await ListModel(this.Request, requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpPost("")]
        public async Task<ActionResult<OrderDetailProductOptionsReadModel>> Create(CancellationToken cancellationToken, [FromForm]OrderDetailProductOptionsCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(Get), new { id = readModel.Id });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<OrderDetailProductOptionsReadModel>> Update(CancellationToken cancellationToken, Guid id, OrderDetailProductOptionsUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });

            return Ok(readModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderDetailProductOptionsReadModel>> Delete(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });

            return Ok(readModel);
        }
    }
}