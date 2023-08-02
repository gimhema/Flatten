using System;
using WebSocketSharp;
using WebSocketSharp.Server;


namespace Flatten.Network.WebSocketAction
{
    public class GameLobby : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
//            int CurrentUserCount = Sessions.Count;
            //            Console.WriteLine("Received Data From Client : " + e.Data + " Current User Num : " + CurrentUserCount);
            // Send(e.Data);
            string sendData = "[GameLobby]" + e.Data;
            Sessions.Broadcast(sendData);
        }
    }
}
