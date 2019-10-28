using System;
using FluentValidation;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Validation
{
    public partial class ApplicationsCreateModelValidator
        : AbstractValidator<ApplicationsCreateModel>
    {
        public ApplicationsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
