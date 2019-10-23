using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OrderDetailsUpdateModelValidator
        : AbstractValidator<OrderDetailsUpdateModel>
    {
        public OrderDetailsUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
