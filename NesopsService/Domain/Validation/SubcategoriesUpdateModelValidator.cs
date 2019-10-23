using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class SubcategoriesUpdateModelValidator
        : AbstractValidator<SubcategoriesUpdateModel>
    {
        public SubcategoriesUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SubcategoryName).NotEmpty();
            RuleFor(p => p.SubcategoryName).MaximumLength(100);
            #endregion
        }

    }
}
