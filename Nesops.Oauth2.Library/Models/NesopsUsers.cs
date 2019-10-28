using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library.Models
{
    public class NesopsUsers : IdentityUser<Guid>
    {
        public string Fullname { get; set; }
        public NesopsUsers()
        {
        }
    }
}
