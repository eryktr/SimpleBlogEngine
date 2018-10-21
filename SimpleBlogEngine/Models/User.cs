using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogEngine.Models
{
    public class User : IEntity
    {
        
        public int UserID { get;  set; }
        public string Username { get;  set; }
        public string Password { get; set; }
        public bool IsAdmin { get;  set; }
        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }

        

    }
}
