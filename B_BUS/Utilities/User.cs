using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Utilities
{
    public class User
    {
        private string userID;
        private string role;
        private List<string> permissions;

        public User()
        {
            
        }

        public User(string userID, string role, List<string> permissions)
        {
            this.userID = userID;
            this.role = role;
            this.permissions = permissions;
        }

        public string UserID { get => userID; set => userID = value; }
        public string Role { get => role; set => role = value; }
        public List<string> Permissions { get => permissions; set => permissions = value; }
    }
}
