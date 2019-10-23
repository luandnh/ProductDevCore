using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ProductAttributesCreateModelValidator
        : AbstractValidator<ProductAttributesCreateModel>
    {
        public ProductAttributesCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
