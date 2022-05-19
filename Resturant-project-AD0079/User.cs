using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_project_AD0079
{
    public  class User
    {
        public string  UserName { get; set; }   
        public string password { get; set; }
        public User(string Username , string password)
        {
            this.UserName = Username;
            this.password = password;
        }
    }
    
}
