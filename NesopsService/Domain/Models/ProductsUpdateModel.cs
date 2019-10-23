using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class ProductsUpdateModel
    {
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

    }
}
