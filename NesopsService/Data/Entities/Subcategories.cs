using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Subcategories : IHaveIdentifier
    {
        public Subcategories()
        {
            #region Generated Constructor
            SubcategoryProducts = new HashSet<Products>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string SubcategoryName { get; set; }

        public Guid CategoryId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Categories CategoryCategories { get; set; }

        public virtual ICollection<Products> SubcategoryProducts { get; set; }

        #endregion

    }
}
