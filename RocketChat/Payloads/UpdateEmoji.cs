using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class UpdateEmoji : Payload
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("emoji")]
        public byte[] Emoji { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("aliases")]
        public string Aliases { get; set; }
    }
}
