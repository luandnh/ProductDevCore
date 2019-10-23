using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OptiongroupsCreateModelValidator
        : AbstractValidator<OptiongroupsCreateModel>
    {
        public OptiongroupsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OptionGroupName).NotEmpty();
            RuleFor(p => p.OptionGroupName).MaximumLength(100);
            #endregion
        }

    }
}
