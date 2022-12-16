using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetReadOnly : Payload
    {
        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }
}
