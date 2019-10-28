using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nesops.Oauth2.Library.Models
{
    public class NesopsApplications
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string RedirectUrl { get; set; }
        public Guid OwnerId { get; set; }

        //Relationship with AspNetUsers
        public virtual NesopsUsers ApplicationsAspNetUsers { get; set; }
    }
}
