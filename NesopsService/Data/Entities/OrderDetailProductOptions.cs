using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class OrderDetailProductOptions : IHaveIdentifier
    {
        public OrderDetailProductOptions()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public Guid OrderDetailId { get; set; }

        public Guid ProductOptionId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual OrderDetails OrderDetailOrderDetails { get; set; }

        public virtual ProductOptions ProductOptionProductOptions { get; set; }

        #endregion

    }
}
