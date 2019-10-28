using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nesops.Oauth2.Library.Services;
using ProductCoreDev.Models;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            if (ticket == null)
            {
                _authorizeModel.SetError("username_password_error", "Invalid username or password");
                _authorizeModel.Rejected();
                return;
            }
            _authorizeModel.Validated(ticket);
            return;
        }
    }
}