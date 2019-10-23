using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetUserClaimsUpdateModelValidator
        : AbstractValidator<AspNetUserClaimsUpdateModel>
    {
        public AspNetUserClaimsUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
