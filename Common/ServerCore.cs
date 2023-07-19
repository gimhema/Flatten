using System;
using Flatten.Common.GameLogic;
using Flatten.Common.UserManagement;
using WebSocketSharp;
using WebSocketSharp.Server;


namespace Flatten.Common
{
    public class ServerCore
    {
        private static ServerCore serverCoreInstance;

        public static ServerCore Instance()
        {
            if (serverCoreInstance == null)
            {
                serverCoreInstance = new ServerCore();
            }
            return serverCoreInstance;
        }

        public UserManager userManager;

        public ServerCore() { }

        public void Initialize()
        {
            Instance();
            userManager = UserManager.Instance();
        }

        public UserManager GetCoreUserManager()
        { 
            return userManager;
        }

        public ServerCore GetServerCoreInstance()
        {
            if(serverCoreInstance != null)
            {
                return serverCoreInstance;
            }
            else
            {
                return Instance();
            }
        }

    }
}
