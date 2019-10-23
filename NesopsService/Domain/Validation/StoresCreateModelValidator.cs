using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class StoresCreateModelValidator
        : AbstractValidator<StoresCreateModel>
    {
        public StoresCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.StoreName).NotEmpty();
            RuleFor(p => p.StoreName).MaximumLength(100);
            #endregion
        }

    }
}
