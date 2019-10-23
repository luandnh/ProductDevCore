using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService.Models
{
    public class AuthorizeModel
    {
        public string Token { get; set; }
        public DateTime Expire { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    }
}
