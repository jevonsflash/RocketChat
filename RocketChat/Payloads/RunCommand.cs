using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class RunCommand : Payload
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("params")]
        public string Params { get; set; }

        [JsonProperty("tmid")]
        public string ThreadMessageId { get; set; }

    }
}
