using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class CreateEmoji : Payload
    {
        [JsonProperty("emoji")]
        public byte[] Emoji { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("aliases")]
        public string Aliases { get; set; }
    }
}
