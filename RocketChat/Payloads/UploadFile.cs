using System.IO;
using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class UploadFile : Payload
    {
        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tmid")]
        public string Tmid { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public Stream File { get; set; }
    }
}
