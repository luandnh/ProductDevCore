using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ProductOptionsCreateModelValidator
        : AbstractValidator<ProductOptionsCreateModel>
    {
        public ProductOptionsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
