using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace Flatten.Common.UserManagement
{
    public class User
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public string Password { get; set; }  


    public User() {
        
        }

    public void Initailize(string name, string id, string password)
        {
            Name = name;
            ID= id;
            Password = password;
        }

    }
}
