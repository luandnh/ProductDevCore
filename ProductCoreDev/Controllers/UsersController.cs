using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nesops.Oauth2.Library.Models;
using Nesops.Oauth2.Library.Services;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.EntityControllerBase;
using NesopsService.Hook.Before;
using NesopsService.Hook.Models.RequestModels;
using ProductCoreDev.Models;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : EntityControllerBase<ProductdevContext, AspNetUsers, AspNetUsersReadModel, AspNetUsersCreateModel, AspNetUsersUpdateModel, AspNetUsersRequestModel, BeforeHookAspNetUsers>
    {
        public readonly AuthorizationService _authorizationService;
        public UsersController(ProductdevContext dataContext, IMapper mapper, BeforeHookAspNetUsers hook, AuthorizationService authorizationService) : base(dataContext, mapper, hook)
        {
            _authorizationService = authorizationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]RegisterModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new NesopsUsers
                    {
                        UserName = model.Username
                    };
                    var userRoles = new List<string>()
                    {
                        "ActiveUser",
                        "Admin"
                    };
                    var result = await _authorizationService.CreateUserAsync(user, model.Password, userRoles);
                    if (result.Succeeded)
                        return Ok(new { message = "You have been registered your account." });
                    foreach (var err in result.Errors)
                        ModelState.AddModelError(err.Code, err.Description);
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}