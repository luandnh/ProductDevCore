using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NesopsAuthorizationService.Identity
{
    public class NesopsUser : IdentityUser<Guid>
    {
        public string Fullname { get; set; }
        public NesopsUser() { 
        }
    }
}
