using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Stores
    {
        public Stores()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string StoreName { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
