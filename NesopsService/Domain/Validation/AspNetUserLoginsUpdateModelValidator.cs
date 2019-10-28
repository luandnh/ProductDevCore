using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetUserLoginsUpdateModelValidator
        : AbstractValidator<AspNetUserLoginsUpdateModel>
    {
        public AspNetUserLoginsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LoginProvider).NotEmpty();
            RuleFor(p => p.LoginProvider).MaximumLength(450);
            RuleFor(p => p.ProviderKey).NotEmpty();
            RuleFor(p => p.ProviderKey).MaximumLength(450);
            #endregion
        }

    }
}
