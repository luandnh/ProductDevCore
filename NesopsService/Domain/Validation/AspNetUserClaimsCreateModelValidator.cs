using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class AspNetUserClaimsCreateModelValidator
        : AbstractValidator<AspNetUserClaimsCreateModel>
    {
        public AspNetUserClaimsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
