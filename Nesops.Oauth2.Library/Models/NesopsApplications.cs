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
        public bool Active { get; set; }
        public DateTime createAt { get; set; } = DateTime.Now;
        public DateTime updateAt { get; set; }

        //Relationship with AspNetUsers
        public virtual NesopsUsers Owner { get; set; }
    }
}
