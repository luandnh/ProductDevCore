using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService.Identity
{
    public class NesopsRole : IdentityRole<Guid>
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public NesopsRole() { }
        public NesopsRole(string roleName) : base(roleName)
        {
        }
    }
}
