using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetUsersCreateModelValidator
        : AbstractValidator<AspNetUsersCreateModel>
    {
        public AspNetUsersCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.UserName).MaximumLength(256);
            RuleFor(p => p.NormalizedUserName).MaximumLength(85);
            RuleFor(p => p.Email).MaximumLength(256);
            RuleFor(p => p.NormalizedEmail).MaximumLength(85);
            #endregion
        }

    }
}
