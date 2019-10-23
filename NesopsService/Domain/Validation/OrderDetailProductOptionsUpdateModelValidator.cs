using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OrderDetailProductOptionsUpdateModelValidator
        : AbstractValidator<OrderDetailProductOptionsUpdateModel>
    {
        public OrderDetailProductOptionsUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
