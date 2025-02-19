using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class ProductOptionsUpdateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid OptionId { get; set; }

        public double PriceIncrement { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
