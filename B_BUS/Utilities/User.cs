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
        private byte role;
        private List<string> permissions;
        private string name;

        public User()
        {
            
        }

        public User(string userID, byte role, List<string> permissions, string name)
        {
            this.userID = userID;
            this.role = role;
            this.permissions = permissions;
            this.name = name;
        }

        public string UserID { get => userID; set => userID = value; }
        public byte Role { get => role; set => role = value; }
        public List<string> Permissions { get => permissions; set => permissions = value; }
        public string Name { get => name; set => name = value; }
    }
}
