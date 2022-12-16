using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class CreateDiscussion : Payload
    {
        [JsonProperty("prid")]
        public string ParentRoomId { get; set; }

        [JsonProperty("t_name")]
        public string DiscussionName { get; set; }

        [JsonProperty("users")]
        public IEnumerable<string> Users { get; set; }

        [JsonProperty("pmid")]
        public string ParentMessageId { get; set; }

        [JsonProperty("excludePinned")]
        public bool ExcludePinned { get; set; }

        [JsonProperty("reply")]
        public string Reply { get; set; }
    }
}
