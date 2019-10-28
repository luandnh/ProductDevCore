using Nesops.Oauth2.Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library.ViewModels
{
    public class NesopsRolesViewModel : BaseViewModel<NesopsRoles>
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("normalizedName", NullValueHandling = NullValueHandling.Ignore)]
        public string NormalizedName { get; set; }
        [JsonProperty("concurrencyStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ConcurrencyStamp { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        public NesopsRolesViewModel() { }
        public NesopsRolesViewModel(NesopsRoles entity) : base(entity)
        {
        }

    }
}
