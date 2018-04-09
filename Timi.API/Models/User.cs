using System.Collections.Generic;

namespace Timi.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public ICollection<Photo> Photos { get; set; }
        public ICollection<Message> MessageSent { get; set; }
        public ICollection<Message> MessageReceived { get; set; }
        
    }
}