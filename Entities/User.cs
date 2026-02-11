using System.Security.Cryptography;

namespace UniBet.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Amount { get; set; }


    }
}
