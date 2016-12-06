using System;

namespace Classes
{
    public class Message
    { 
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime SentDate { get; set; }
        public string RecipientName { get; set; }
        public string UserName { get; set; }
    }
}
