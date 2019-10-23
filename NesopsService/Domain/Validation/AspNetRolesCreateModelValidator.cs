using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetRolesCreateModelValidator
        : AbstractValidator<AspNetRolesCreateModel>
    {
        public AspNetRolesCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(256);
            RuleFor(p => p.NormalizedName).MaximumLength(85);
            #endregion
        }

    }
}
