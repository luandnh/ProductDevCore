using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductCoreDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("1")]
        [AllowAnonymous]
        public IActionResult Test1()
        {
            return Ok(User.Identity.IsAuthenticated +" --- "+ User.Identity.Name);
        }
        [HttpGet("2")]
        [Authorize(Roles ="ActiveUser")]
        public IActionResult Test2()
        {
            return Ok(User.Identity.IsAuthenticated + " --- " + User.Identity.Name);
        }
    }
}