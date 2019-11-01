using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class ApplicationsUpdateModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string RedirectUrl { get; set; }

        public Guid? OwnerId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
