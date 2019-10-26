using NesopsService.Identifier;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Options : IHaveIdentifier
    {
        public Options()
        {
            #region Generated Constructor
            OptionProductOptions = new HashSet<ProductOptions>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string OptionName { get; set; }

        public Guid OptionGroupId { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Optiongroups OptionGroupOptiongroups { get; set; }

        public virtual ICollection<ProductOptions> OptionProductOptions { get; set; }

        #endregion

    }
}
