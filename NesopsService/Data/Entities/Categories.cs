using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Categories: IHaveIdentifier
    {
        public Categories()
        {
            #region Generated Constructor
            CategorySubcategories = new HashSet<Subcategories>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string CategoryName { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Subcategories> CategorySubcategories { get; set; }

        #endregion

    }
}
