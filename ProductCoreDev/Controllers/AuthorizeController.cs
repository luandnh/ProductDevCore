using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NesopsAuthorizationService.Services;
using NesopsAuthorizationService.ViewModels;
using ProductCoreDev.Models;

namespace productdevapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorizeController : ControllerBase
    {
        public readonly AuthorizationService _authorizationService;
        public AuthorizeController(AuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        private AuthorizeModel _authorizeModel;
        [HttpPost]
        public async Task<IActionResult> Login([FromForm]LoginModel model)
        {
            _authorizeModel = new AuthorizeModel();
            await AspUserCredentials(model);
            if (!_authorizeModel.valid)
            {
                return Unauthorized(_authorizeModel.errors);
            }
            var res = _authorizationService.GetTokenResponse(_authorizeModel.ticket);
            return Ok(res);
        }
        private async Task AspUserCredentials(LoginModel model)
        {
            var ticket = await _authorizationService.GetAuthenticateTicketAsync(model.username, model.password);
            if(ticket == null)
            {
                _authorizeModel.SetError("username_password_error", "Invalid username or password");
                _authorizeModel.Rejected();
                return;
            }
            _authorizeModel.Validated(ticket);
            return;
        }

        [HttpGet("role")]
        public async Task<IActionResult> GetRoles() {
            try { 
            return Ok( await _authorizationService.GetRoles());
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpPost("role")]
        public async Task<IActionResult> CreateRole(NesopsRoleViewModel role)
        {
            try
            {
                var entity = role.ToEntity();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                var result = await _authorizationService.CreateRoleAsync(entity);
                if (result.Succeeded)
                    return Ok(new NesopsRoleViewModel(entity));
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