using Nesops.Oauth2.Library.Models;
using NesopsService.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCoreDev.Models
{
    public class RegisterModel
    {
        [Required]
        [StringLength(100, MinimumLength = 6)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class NesopsRolesCreateModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [Required]
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
    public partial class NesopsRoleProfile
    : AutoMapper.Profile
    {
        public NesopsRoleProfile()
        {
            CreateMap<NesopsRoles, AspNetRolesReadModel>();
        }
    }
}
