using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class AspNetRoles : IHaveIdentifier
    {
        public AspNetRoles()
        {
            #region Generated Constructor
            RoleAspNetRoleClaims = new HashSet<AspNetRoleClaims>();
            RoleAspNetUserRoles = new HashSet<AspNetUserRoles>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<AspNetRoleClaims> RoleAspNetRoleClaims { get; set; }

        public virtual ICollection<AspNetUserRoles> RoleAspNetUserRoles { get; set; }

        #endregion

    }
}
