using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogEngine.Models
{
    public class User
    {
        
        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }
        public User(string username, string password, bool isAdmin)
        {
            Username = username;
        }

        

    }
}
