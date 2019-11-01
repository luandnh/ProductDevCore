using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class ApplicationsCreateModel
    {
        #region Generated Properties

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string RedirectUrl { get; set; }

        public Guid? OwnerId { get; set; }

        public bool Active { get; set; } =true;

        #endregion

    }
}
