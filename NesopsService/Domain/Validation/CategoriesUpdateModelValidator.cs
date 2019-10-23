using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class CategoriesUpdateModelValidator
        : AbstractValidator<CategoriesUpdateModel>
    {
        public CategoriesUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).NotEmpty();
            RuleFor(p => p.CategoryName).MaximumLength(100);
            #endregion
        }

    }
}
