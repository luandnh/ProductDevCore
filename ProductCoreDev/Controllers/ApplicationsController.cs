using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nesops.Oauth2.Library.DataContext;
using Nesops.Oauth2.Library.Services;
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
    public class ApplicationsController : EntityControllerBase<ProductdevContext, Applications, ApplicationsReadModel, ApplicationsCreateModel, ApplicationsUpdateModel, ApplicationsRequestModel, BeforeHookApplications>
    {
        public ApplicationsController(ProductdevContext dataContext, IMapper mapper, BeforeHookApplications hook) : base(dataContext, mapper, hook)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetResponseModel<ApplicationsReadModel, ApplicationsRequestModel>>> Get(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await ReadModel(this.Request, id, cancellationToken);
            if (readModel == null)
                return NotFound(new ErrorResponseModel<object> { message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpGet]
        public async Task<ActionResult<GetResponseModel<ApplicationsReadModel, ApplicationsRequestModel>>> List(CancellationToken cancellationToken, [FromQuery]  ApplicationsRequestModel requestModel)
        {
            var readModels = await ListModel(this.Request, requestModel, cancellationToken);
            return Ok(readModels);
        }
        [HttpGet]
        [Route("redirect/valid")]
        [AllowAnonymous]
        public IActionResult IsValidRedirect(string url)
        {
            return Ok(_hook.IsValidRedirectUrl(url));
        }
        [HttpPost]
        public async Task<ActionResult<ApplicationsReadModel>> Create(CancellationToken cancellationToken, [FromForm]ApplicationsCreateModel createModel)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if(userId == null || userId == "")
            {
                return Unauthorized();
            }
            createModel.OwnerId = Guid.Parse(userId);
            createModel.RedirectUrl = new Uri(createModel.RedirectUrl).AbsoluteUri;
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(Get), new { id = readModel.Id },readModel);
        }
    }
}