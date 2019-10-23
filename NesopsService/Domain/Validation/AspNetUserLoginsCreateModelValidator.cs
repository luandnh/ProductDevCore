using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetUserLoginsCreateModelValidator
        : AbstractValidator<AspNetUserLoginsCreateModel>
    {
        public AspNetUserLoginsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LoginProvider).NotEmpty();
            RuleFor(p => p.LoginProvider).MaximumLength(85);
            RuleFor(p => p.ProviderKey).NotEmpty();
            RuleFor(p => p.ProviderKey).MaximumLength(85);
            #endregion
        }

    }
}
