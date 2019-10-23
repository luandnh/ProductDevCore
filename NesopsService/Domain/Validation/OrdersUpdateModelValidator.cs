using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class OrdersUpdateModelValidator
        : AbstractValidator<OrdersUpdateModel>
    {
        public OrdersUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ShipPhone).NotEmpty();
            RuleFor(p => p.ShipPhone).MaximumLength(20);
            RuleFor(p => p.ShipAddress).NotEmpty();
            RuleFor(p => p.ShipAddress).MaximumLength(200);
            RuleFor(p => p.ShipCity).NotEmpty();
            RuleFor(p => p.ShipCity).MaximumLength(50);
            RuleFor(p => p.ShipState).NotEmpty();
            RuleFor(p => p.ShipState).MaximumLength(50);
            RuleFor(p => p.ShipCountry).NotEmpty();
            RuleFor(p => p.ShipCountry).MaximumLength(50);
            #endregion
        }

    }
}
