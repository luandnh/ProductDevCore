using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ProductAttributesUpdateModelValidator
        : AbstractValidator<ProductAttributesUpdateModel>
    {
        public ProductAttributesUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
