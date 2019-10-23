using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CategoriesUpdateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public string CategoryName { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
