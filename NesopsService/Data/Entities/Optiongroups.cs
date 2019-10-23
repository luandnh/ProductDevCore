using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class Optiongroups
    {
        public Optiongroups()
        {
            #region Generated Constructor
            OptionGroupOptions = new HashSet<Options>();
            #endregion
        }

        #region Generated Properties
        public Guid Id { get; set; }

        public string OptionGroupName { get; set; }

        public bool Active { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Options> OptionGroupOptions { get; set; }

        #endregion

    }
}
