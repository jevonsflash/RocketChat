using RocketChat.Models;
using System.Collections.Generic;

namespace RocketChat.MethodResults.Channels
{
    public class OnlineResult
    {
        public IEnumerable<User> Online { get; set; }
        public bool Success { get; set; }
    }
}