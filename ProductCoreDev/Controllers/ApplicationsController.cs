using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nesops.Oauth2.Library.DataContext;
using Nesops.Oauth2.Library.Services;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly AuthorizationService _authorizationService;
        private readonly NesopsDbContext _dbcontext;
        public ApplicationsController(AuthorizationService authorizationService, NesopsDbContext dbcontext)
        {
            _authorizationService = authorizationService;
            _dbcontext = dbcontext;
        }
        [HttpGet]
        [Route("redirect/valid")]
        [AllowAnonymous]
        public IActionResult IsValidRedirect(string url)
        {
            return Ok(_authorizationService.IsValidRedirectUrl(url));
        }
    }
}