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
            RuleFor(x => x.RedirectUrl)
            .Must(LinkMustBeAUri)
            .WithMessage("Link '{PropertyValue}' must be a valid URI. eg: http://www.SomeWebSite.com.au");

        }
        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }
            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }

    }
}
