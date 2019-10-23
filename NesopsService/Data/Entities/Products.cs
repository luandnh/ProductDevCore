using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Products : IHaveIdentifier
    {
        public Products()
        {
            #region Generated Constructor
            ProductOrderDetails = new HashSet<OrderDetails>();
            ProductProductAttributes = new HashSet<ProductAttributes>();
            ProductProductImages = new HashSet<ProductImages>();
            ProductProductOptions = new HashSet<ProductOptions>();
            ProductProductVideos = new HashSet<ProductVideos>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public string ProductSku { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public int Status { get; set; }

        public Guid SubcategoryId { get; set; }

        public double CurrentPrice { get; set; }

        public double? OldPrice { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<OrderDetails> ProductOrderDetails { get; set; }

        public virtual ICollection<ProductAttributes> ProductProductAttributes { get; set; }

        public virtual ICollection<ProductImages> ProductProductImages { get; set; }

        public virtual ICollection<ProductOptions> ProductProductOptions { get; set; }

        public virtual ICollection<ProductVideos> ProductProductVideos { get; set; }

        public virtual Subcategories SubcategorySubcategories { get; set; }

        #endregion

    }
}
