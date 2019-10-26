using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Orders : IHaveIdentifier
    {
        public Orders()
        {
            #region Generated Constructor
            OrderOrderDetails = new HashSet<OrderDetails>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public double OrderAmount { get; set; }

        public string ShipPhone { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipState { get; set; }

        public string ShipCountry { get; set; }

        public bool ShipStatus { get; set; }

        public DateTime ShipDate { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<OrderDetails> OrderOrderDetails { get; set; }

        public virtual AspNetUsers UserAspNetUsers { get; set; }

        #endregion

    }
}
