using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Applications
    {
        public Applications()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string RedirectUrl { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ApplicationsAspNetUsersId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AspNetUsers AspNetUsers { get; set; }

        #endregion

    }
}
