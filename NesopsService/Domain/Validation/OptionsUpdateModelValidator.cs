using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OptionsUpdateModelValidator
        : AbstractValidator<OptionsUpdateModel>
    {
        public OptionsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OptionName).NotEmpty();
            RuleFor(p => p.OptionName).MaximumLength(200);
            #endregion
        }

    }
}
