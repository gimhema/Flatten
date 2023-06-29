using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace Flatten.Common.UserManagement
{
    public class User
    {
        public string Name { get; set; }
        public string ID { get; set; }


    public User() {
        
        }

    public void Initailize(string name, string id)
        {
            Name = name;
            ID= id;
        }

    }
}
