using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Example2
{
    public class Echo : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            int CurrentUserCount = Sessions.Count;
            Console.WriteLine( "Received Data From Client : " + e.Data + " Current User Num : " + CurrentUserCount);
            // Send(e.Data);
            Sessions.Broadcast(e.Data);
        }
    }
}