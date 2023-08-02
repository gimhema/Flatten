using Flatten;
using System;
using WebSocketSharp;
using WebSocketSharp.Server;
using Flatten.Common;
using Flatten.Common.UserManagement;

namespace Flatten.Network.WebSocketAction
{
    public class EnterGameLobby : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            string message = e.Data;

            string[] parseResult = ParseUserInfo(message);

            if (CheckValidUserAuth(parseResult[0], parseResult[1]))
            {
                string authCheckSucessMSG = "welcome to the game lobby ! !";
                Send(authCheckSucessMSG);

                // Add New User to UserManager
                var userManagerInstance = UserManager.Instance();
                userManagerInstance.AddUser(parseResult[0], parseResult[1], "");
                userManagerInstance.ShowAllUser();
            }

        }

        public string[] ParseUserInfo(string enteringMessage)
        {
            char[] delimiterChars = { ':' };

            return enteringMessage.Split(delimiterChars);            
        }
        public bool CheckValidUserAuth(string userID, string password)
        {
            if(userID == null || password == null)
            {
                return false;
            }
            Console.WriteLine("User Checked ID : " + userID + " PW : " + password);

            // Check user ID and User Password . . . 

            // need DB Process . . .

            return true;
        }
    }
}
