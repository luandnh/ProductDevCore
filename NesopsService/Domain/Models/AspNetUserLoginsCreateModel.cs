using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class AspNetUserLoginsCreateModel
    {
        #region Generated Properties
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string ProviderDisplayName { get; set; }

        public Guid UserId { get; set; }

        #endregion

    }
}
