using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ProductsCreateModelValidator
        : AbstractValidator<ProductsCreateModel>
    {
        public ProductsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MaximumLength(100);
            RuleFor(p => p.ProductSku).NotEmpty();
            RuleFor(p => p.ProductSku).MaximumLength(50);
            RuleFor(p => p.ShortDesc).MaximumLength(1000);
            #endregion
        }

    }
}
