using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Applications : IHaveIdentifier
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

        public Guid? OwnerId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AspNetUsers OwnerAspNetUsers { get; set; }

        #endregion

    }
}
