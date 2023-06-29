using System;
using System.Collections.Generic;
using Flatten.Common.UserManagement;

namespace Flatten.Common.UserManagement
{
    public class UserManager
    {
        public Dictionary<string, User> userContainer = new Dictionary<string, User>();

        public UserManager() {
        
        }

        public void AddUser(string ID, string userName) {
           
            User user= new User();
            user.Initailize(userName, ID);
            userContainer.Add(userName, user);
        }

        public void RemoveUser(string userName)
        {
            if (userContainer.ContainsKey(userName))
            {
                userContainer.Remove(userName);
            }
        }

        public User GetUser(string userName)
        {
            return userContainer[userName];
        }

        public string GetUserIDByName(string userName)
        {
            return userContainer[userName].ID;
        }
    }
}
