using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CategoriesCreateModelValidator
        : AbstractValidator<CategoriesCreateModel>
    {
        public CategoriesCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).NotEmpty();
            RuleFor(p => p.CategoryName).MaximumLength(100);
            RuleFor(p => p.CategoryName).MinimumLength(5);
            #endregion
        }

    }
}
