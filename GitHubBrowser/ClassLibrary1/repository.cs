using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
    public class Repository
    {
        public Repository(string username, string repname, string description, HashSet<languages> languages, string avatar, string email)
        {
            Username = username;
            RepName = repname;
            Description = description;
            Languages = languages;
            Avatar = avatar;
            Email = email;
        }
      public string Username {get;private set;}
      public string RepName { get; private set; }
      public string Description { get; private set; }
      public HashSet<languages> Languages { get; private set; }
      public string Avatar { get; private set; }
      public string Email { get; private set; } 
    }
    
}
