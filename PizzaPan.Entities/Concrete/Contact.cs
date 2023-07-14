using System;

namespace PizzaPan.Entities.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SendDateMessage { get; set; }
    }
}
