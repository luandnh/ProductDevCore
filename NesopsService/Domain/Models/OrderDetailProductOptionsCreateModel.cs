using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class OrderDetailProductOptionsCreateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public Guid OrderDetailId { get; set; }

        public Guid ProductOptionId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
