using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class OrdersReadModel
    {
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

    }
}
