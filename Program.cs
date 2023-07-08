using Flatten.Network.WebSocketAction;
using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace Example2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var wssv = new WebSocketServer(4649);
            //var wssv = new WebSocketServer (5963, true);

            //var wssv = new WebSocketServer (System.Net.IPAddress.Any, 4649);
            //var wssv = new WebSocketServer (System.Net.IPAddress.Any, 5963, true);

            //var wssv = new WebSocketServer (System.Net.IPAddress.IPv6Any, 4649);
            //var wssv = new WebSocketServer (System.Net.IPAddress.IPv6Any, 5963, true);

            //var wssv = new WebSocketServer ("ws://0.0.0.0:4649");
            //var wssv = new WebSocketServer ("wss://0.0.0.0:5963");

            //var wssv = new WebSocketServer ("ws://[::0]:4649");
            //var wssv = new WebSocketServer ("wss://[::0]:5963");

            //var wssv = new WebSocketServer (System.Net.IPAddress.Loopback, 4649);
            //var wssv = new WebSocketServer (System.Net.IPAddress.Loopback, 5963, true);

            //var wssv = new WebSocketServer (System.Net.IPAddress.IPv6Loopback, 4649);
            //var wssv = new WebSocketServer (System.Net.IPAddress.IPv6Loopback, 5963, true);

            //var wssv = new WebSocketServer ("ws://localhost:4649");
            //var wssv = new WebSocketServer ("wss://localhost:5963");

            //var wssv = new WebSocketServer ("ws://127.0.0.1:4649");
            //var wssv = new WebSocketServer ("wss://127.0.0.1:5963");

            //var wssv = new WebSocketServer ("ws://[::1]:4649");
            //var wssv = new WebSocketServer ("wss://[::1]:5963");

            wssv.AddWebSocketService<Echo>("/Echo");
            wssv.AddWebSocketService<Start>("/Start");
            wssv.AddWebSocketService<EnterGameLobby>("/EnterGameLobby");

            

            wssv.Start();

            if (wssv.IsListening)
            {
                Console.WriteLine("Listening on port {0}, and providing WebSocket services:", wssv.Port);

                foreach (var path in wssv.WebSocketServices.Paths)
                    Console.WriteLine("- {0}", path);
            }

            Console.WriteLine("\nPress Enter key to stop the server...");
            Console.ReadLine();

            wssv.Stop();
        }
    }
}