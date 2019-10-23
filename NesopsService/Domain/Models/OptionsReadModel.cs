using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class OptionsReadModel
    {
        #region Generated Properties
        public Guid Id { get; set; }

        public string OptionName { get; set; }

        public Guid OptionGroupId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

    }
}
