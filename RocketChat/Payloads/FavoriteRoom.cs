using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class FavoriteRoom : Payload
    {
        [JsonProperty("favorite")]
        public bool Favorite { get; set; }
    }
}
