using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetUserTokensUpdateModelValidator
        : AbstractValidator<AspNetUserTokensUpdateModel>
    {
        public AspNetUserTokensUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LoginProvider).NotEmpty();
            RuleFor(p => p.LoginProvider).MaximumLength(85);
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(85);
            #endregion
        }

    }
}