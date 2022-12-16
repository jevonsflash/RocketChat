using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Role
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("rid")]
        public string RoomId { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }
    }
}
