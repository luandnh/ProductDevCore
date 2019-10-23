using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OrderDetailProductOptionsCreateModelValidator
        : AbstractValidator<OrderDetailProductOptionsCreateModel>
    {
        public OrderDetailProductOptionsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
