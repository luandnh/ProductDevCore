using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library.Models
{
    public class NesopsRoles : IdentityRole<Guid>
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public NesopsRoles() { }
        public NesopsRoles(string roleName) : base(roleName)
        {
        }
    }
}
