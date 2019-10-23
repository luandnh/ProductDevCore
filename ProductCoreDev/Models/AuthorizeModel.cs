using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCoreDev.Models
{
    public class AuthorizeModel
    {
        public IDictionary<string, string> errors { get; } = new Dictionary<string, string>();
        public bool valid { get; set; } = true;
        public AuthenticationTicket ticket { get; private set; }
        public void Validated(AuthenticationTicket _ticket)
        {
            ticket = _ticket;
        }
        public void SetError(string name,string value)
        {
            errors[name] = value;
        }
        public void Rejected()
        {
            valid = false;
        }
     }

    public class LoginModel
    {
        [JsonProperty("username")]
        public string username { get; set; }
        [JsonProperty("password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
