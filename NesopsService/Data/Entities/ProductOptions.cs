using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class ProductOptions : IHaveIdentifier
    {
        public ProductOptions()
        {
            #region Generated Constructor
            ProductOptionOrderDetailProductOptions = new HashSet<OrderDetailProductOptions>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid OptionId { get; set; }

        public double PriceIncrement { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Options OptionOptions { get; set; }

        public virtual ICollection<OrderDetailProductOptions> ProductOptionOrderDetailProductOptions { get; set; }

        public virtual Products ProductProducts { get; set; }

        #endregion

    }
}
