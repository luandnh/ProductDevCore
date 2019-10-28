using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nesops.Oauth2.Library.Models;
using Nesops.Oauth2.Library.Services;
using Nesops.Oauth2.Library.ViewModels;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.EntityControllerBase;
using NesopsService.Hook.Before;
using NesopsService.Hook.Models.RequestModels;
using NesopsService.Hook.Models.ResponseModels;
using ProductCoreDev.Models;

namespace Nesops.Oauth2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : EntityControllerBase<ProductdevContext, AspNetRoles, AspNetRolesReadModel, AspNetRolesCreateModel, AspNetRolesUpdateModel, AspNetRolesRequestModel, BeforeHookAspNetRoles>
    {
        public readonly AuthorizationService _authorizationService;

        public RolesController(ProductdevContext dataContext, IMapper mapper, BeforeHookAspNetRoles hook, AuthorizationService authorizationService) : base(dataContext, mapper, hook)
        {
            _authorizationService = authorizationService;
        }

        [HttpGet]
        public async Task<ActionResult<GetResponseModel<AspNetRolesReadModel, AspNetRolesRequestModel>>> Get(CancellationToken cancellationToken, [FromQuery]  AspNetRolesRequestModel requestModel)
        {
            var readModels = await ListModel(this.Request, requestModel, cancellationToken);
            return Ok(readModels);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromForm] NesopsRolesCreateModel model)
        {
            try
            {
                var role = new NesopsRolesViewModel
                {
                    Name = model.Name,
                    DisplayName = model.DisplayName,
                    Description = model.Description,
                    ConcurrencyStamp = Guid.NewGuid().ToString()
            };
                var entity = role.ToEntity();
                var result = await _authorizationService.CreateRoleAsync(entity);
                if (result.Succeeded)
                    return Ok(new NesopsRolesViewModel(entity));
                foreach (var err in result.Errors)
                    ModelState.AddModelError(err.Code, err.Description);
                return BadRequest(ModelState);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}