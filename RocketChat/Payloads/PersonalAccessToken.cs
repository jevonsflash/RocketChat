using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class PersonalAccessToken : Payload
    {
        [JsonProperty("tokenName")]
        public string TokenName { get; set; }
    }
}
