using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetActive : Payload
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("activeStatus")]
        public bool ActiveStatus { get; set; }
    }
}
