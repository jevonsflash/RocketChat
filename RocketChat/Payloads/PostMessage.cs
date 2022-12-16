using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class PostMessage : Payload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }

        public class Attachment
        {
            [JsonProperty("color")]
            public string Color { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("channel")]
            public string Channel { get; set; }

            [JsonProperty("ts")]
            public DateTime TimeStamp { get; set; }

            [JsonProperty("thumb_url")]
            public string ThumbUrl { get; set; }

            [JsonProperty("message_link")]
            public string MessageLink { get; set; }

            [JsonProperty("collapsed")]
            public bool Collapsed { get; set; }

            [JsonProperty("author_name")]
            public string AuthorName { get; set; }

            [JsonProperty("author_link")]
            public string AuthorLink { get; set; }

            [JsonProperty("author_icon")]
            public string AuthorIcon { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("title_link")]
            public string TitleLink { get; set; }

            [JsonProperty("title_link_download")]
            public bool TitleLinkDownload { get; set; }

            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }

            [JsonProperty("audio_url")]
            public string AudioUrl { get; set; }

            [JsonProperty("video_url")]
            public string VideoUrl { get; set; }

            [JsonProperty("fields")]
            public IEnumerable<Field> Fields { get; set; }

            public class Field
            {
                [JsonProperty("title")]
                public string Title { get; set; }

                [JsonProperty("value")]
                public string Value { get; set; }
            }
        }
    }
}
