using RocketChat.Models;
using System.Collections.Generic;

namespace RocketChat.MethodResults.Channels
{
    public class RolesResult
    {
        public IEnumerable<Role> Roles { get; set; }
        public bool Success { get; set; }
    }
}