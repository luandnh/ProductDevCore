using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OrderDetailsCreateModelValidator
        : AbstractValidator<OrderDetailsCreateModel>
    {
        public OrderDetailsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
