using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class AspNetUserTokensCreateModel
    {
        #region Generated Properties
        public Guid UserId { get; set; }

        public string LoginProvider { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        #endregion

    }
}
