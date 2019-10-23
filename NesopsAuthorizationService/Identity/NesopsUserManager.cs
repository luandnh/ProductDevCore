using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NesopsAuthorizationService.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService.Identity
{
    public class NesopsUserManager : UserManager<NesopsUser>
    {
        public NesopsUserManager(IUserStore<NesopsUser> userStore, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<NesopsUser> passwordHasher, IEnumerable<IUserValidator<NesopsUser>> userValidators, IEnumerable<IPasswordValidator<NesopsUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<NesopsUser>> logger) : base(userStore, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
