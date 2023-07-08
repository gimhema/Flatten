﻿using System;
using WebSocketSharp;
using WebSocketSharp.Server;

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
                string authCheckSucessMSG = "userInfoValid";
                Send(authCheckSucessMSG);
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