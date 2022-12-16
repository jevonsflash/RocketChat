using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetCustomFields : Payload
    {
        [JsonProperty("roomName")]
        public string RoomName { get; set; }

        [JsonProperty("customFields")]
        public string CustomFields { get; set; }
    }
}
