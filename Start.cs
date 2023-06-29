using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Example2
{
    public class Start : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            int CurrentUserCount = Sessions.Count;
            Console.WriteLine("[" + ID.ToString() + "] : " + e.Data);
            // Send(e.Data);
            Sessions.Broadcast(e.Data);
            
        }
    }
}