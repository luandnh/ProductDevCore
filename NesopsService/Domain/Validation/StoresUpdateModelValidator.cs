using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class StoresUpdateModelValidator
        : AbstractValidator<StoresUpdateModel>
    {
        public StoresUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.StoreName).NotEmpty();
            RuleFor(p => p.StoreName).MaximumLength(100);
            #endregion
        }

    }
}
