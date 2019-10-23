using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ProductVideosUpdateModelValidator
        : AbstractValidator<ProductVideosUpdateModel>
    {
        public ProductVideosUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(100);
            RuleFor(p => p.Path).MaximumLength(200);
            RuleFor(p => p.Url).MaximumLength(500);
            #endregion
        }

    }
}
