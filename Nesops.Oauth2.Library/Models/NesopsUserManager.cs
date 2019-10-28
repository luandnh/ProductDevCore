using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library.Models
{
    public class NesopsUserManager : UserManager<NesopsUsers>
    {
        public NesopsUserManager(IUserStore<NesopsUsers> userStore, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<NesopsUsers> passwordHasher, IEnumerable<IUserValidator<NesopsUsers>> userValidators, IEnumerable<IPasswordValidator<NesopsUsers>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<NesopsUsers>> logger) : base(userStore, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
