using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RocketChat.JsonConverters;

namespace RocketChat.Models
{
    public class FullUser
    {
        public string Id { get; set; }

        [JsonConverter(typeof(MeteorDateConverter))]
        public DateTime CreatedAt { get; set; }

        public string Username { get; set; }

        public List<Email> Emails { get; set; }

        public string Status { get; set; }

        public bool Active { get; set; }

        public List<string> Roles { get; set; }
    }
}