using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ProductImagesUpdateModelValidator
        : AbstractValidator<ProductImagesUpdateModel>
    {
        public ProductImagesUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(100);
            RuleFor(p => p.ThumbnailPath).MaximumLength(200);
            RuleFor(p => p.Path).NotEmpty();
            RuleFor(p => p.Path).MaximumLength(200);
            #endregion
        }

    }
}
