using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class DeleteEmoji : Payload
    {
        [JsonProperty("emojiId")]
        public string EmojiId { get; set; }
    }
}
