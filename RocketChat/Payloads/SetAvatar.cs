using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetAvatar : Payload
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
    }
}
