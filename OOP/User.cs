using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String PasswordHash { get; set; }

        public User(int Id, String username, String passwordHash)
        {
            this.Id = Id;
            this.Username = username;
            this.PasswordHash = passwordHash;
        }
        
        public override String ToString() { return $"<User Id={Id} Username={Username}>"; }
    }
}
