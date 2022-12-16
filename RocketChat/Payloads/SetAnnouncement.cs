using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetAnnouncement : Payload
    {
        [JsonProperty("announcement")]
        public string Announcement { get; set; }
    }
}
