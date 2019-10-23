using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NesopsAuthorizationService.DBContext;
using NesopsAuthorizationService.Identity;
using NesopsAuthorizationService.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NesopsAuthorizationService.Services
{
    public class AuthorizationService
    {
        public NesopsUserManager _userManager { get; set; }
        public RoleManager<NesopsRole> _roleManager { get; set; }
        public SignInManager<NesopsUser> _signInManager { get; set; }
        public NesopsIdentityDbContext _dbContext { get; set; }
        public AuthorizationService(NesopsUserManager userManager, 
            RoleManager<NesopsRole> roleManager, 
            SignInManager<NesopsUser> signInManager, 
            NesopsIdentityDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
        }
        public virtual async Task<AuthenticationTicket> GetAuthenticateTicketAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null || !(await _userManager.CheckPasswordAsync(user, password)))
            {
                return null;
            }
            var identity = new ClaimsIdentity("application");
            identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = (await _userManager.GetRolesAsync(user));
            foreach (var userRole in userRoles)
            {
                userClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }
            var principal = new ClaimsPrincipal(identity);
            var prop = new AuthenticationProperties()
            {
                IssuedUtc = DateTime.UtcNow,
                ExpiresUtc = DateTime.UtcNow.AddDays(1)
            };
            return new AuthenticationTicket(principal, prop, "application");
        }
        public IDictionary<string,object> GetTokenResponse(AuthenticationTicket ticket)
        {
            var res = new Dictionary<string, object>();


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.Default.GetBytes(NesopsJwtConfiguration.Nesops_SecretKey);
            var issuer = NesopsJwtConfiguration.Nesops_Issuer;
            var audience = NesopsJwtConfiguration.Nesops_Audience;
            var identity = ticket.Principal.Identity as ClaimsIdentity;
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub, ticket.Principal.Identity.Name));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,
                Audience = audience,
                Subject = new ClaimsIdentity(identity),
                IssuedAt = ticket.Properties.IssuedUtc?.UtcDateTime,
                Expires = ticket.Properties.ExpiresUtc?.UtcDateTime,
                NotBefore = ticket.Properties.IssuedUtc?.UtcDateTime,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            res["access_token"] = tokenString;
            if (ticket.Properties.ExpiresUtc != null)
                res["expires_utc"] = ticket.Properties.ExpiresUtc;
            if (ticket.Properties.IssuedUtc != null)
                res["issued_utc"] = ticket.Properties.IssuedUtc;
            return res;
        }
        public async Task<IdentityResult> CreateRoleAsync(NesopsRole role)
        {
            var result = await _roleManager.CreateAsync(role);
            return result;
        }
        public async Task<IdentityResult> CreateUserAsync(NesopsUser user, string password, IEnumerable<string> roles = null)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                var result = await _userManager.CreateAsync(user, password);
                if (!result.Succeeded) return result;
                if (roles != null) result = await _userManager.AddToRolesAsync(user, roles);
                if (result.Succeeded) transaction.Commit();
                return result;
            }
        }

        public async Task<List<NesopsRole>> GetRoles()
        {
            var result =  await _roleManager.Roles.ToListAsync();
            return result;
        }
    }
}
