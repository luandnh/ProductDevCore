using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            #region Generated Constructor
            OrderDetailOrderDetailProductOptions = new HashSet<OrderDetailProductOptions>();
            #endregion
        }

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

        #region Generated Relationships
        public virtual ICollection<OrderDetailProductOptions> OrderDetailOrderDetailProductOptions { get; set; }

        public virtual Orders OrderOrders { get; set; }

        public virtual Products ProductProducts { get; set; }

        #endregion

    }
}
