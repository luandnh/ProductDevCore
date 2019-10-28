using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nesops.Oauth2.Library.Models;
using Nesops.Oauth2.Library.Services;
using ProductCoreDev.Models;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly AuthorizationService _authorizationService;
        public UsersController(AuthorizationService authorizationService)
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