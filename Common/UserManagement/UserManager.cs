﻿using System;
using System.Collections.Generic;
using Flatten.Common.UserManagement;

namespace Flatten.Common.UserManagement
{
    public class UserManager
    {
        private static UserManager userManagerInstance;

        public static UserManager Instance() 
        {
            if(userManagerInstance == null)
            {
                userManagerInstance = new UserManager();
            }

            return userManagerInstance; 
        }

        public Dictionary<string, User> userContainer = new Dictionary<string, User>();

        public UserManager() {
        
        }

        public void ShowAllUser()
        {
            foreach(var userName in userContainer.Keys) 
            { 
                Console.WriteLine("Current User : " + userName);
            }
        }

        public void AddUser(string ID, string userName, string password) {
           
            User user= new User();
            user.Initailize(userName, ID, password);
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
