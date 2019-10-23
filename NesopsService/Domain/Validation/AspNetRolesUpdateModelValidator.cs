using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetRolesUpdateModelValidator
        : AbstractValidator<AspNetRolesUpdateModel>
    {
        public AspNetRolesUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(256);
            RuleFor(p => p.NormalizedName).MaximumLength(85);
            #endregion
        }

    }
}
