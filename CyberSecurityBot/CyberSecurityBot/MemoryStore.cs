using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot
{
    public class MemoryStore
    {
        public string UserName { get; set; }
        public string FavoriteTopic { get; set; }

        public bool HasName => !string.IsNullOrWhiteSpace(UserName);
    }
}
