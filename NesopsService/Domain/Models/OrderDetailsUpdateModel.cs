using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class OrderDetailsUpdateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
