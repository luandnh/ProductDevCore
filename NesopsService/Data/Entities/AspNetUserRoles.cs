using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class AspNetUserRoles
    {
        public AspNetUserRoles()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AspNetRoles RoleAspNetRoles { get; set; }

        public virtual AspNetUsers UserAspNetUsers { get; set; }

        #endregion

    }
}
