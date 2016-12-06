using System;
using System.Collections.Generic;
using System.Drawing;

namespace Classes
{
    [Serializable]
    public class Packet
    {
        public TypeData Type { get; set; }
        public string Message { get; set; }
        public List<User> UsersList { get; set; }
        public Color Color { get; set; }
        public string NickName { get; set; }
        public User User { get; set; }
        public int ID { get; set; }
        public bool? IsExists { get; set; }
        public string MessageText { get; set; }
    }
}
