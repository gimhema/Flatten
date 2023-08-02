using Flatten.Network.WebSocketAction;
using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;
using Flatten.Common.UserManagement;
using Flatten.Common;

namespace Example2
{
    public class Program
    {
        public static ServerCore serverCoreGlobal;
        public void InitializeServerCore()
        {
            serverCoreGlobal = new ServerCore();
            serverCoreGlobal.Initialize();
        }
        public static void Main(string[] args)
        {

            var wssv = new WebSocketServer(4649);

            wssv.AddWebSocketService<Echo>("/Echo");
            wssv.AddWebSocketService<Start>("/Start");
            wssv.AddWebSocketService<EnterGameLobby>("/EnterGameLobby");
            wssv.AddWebSocketService<GameLobby>("/GameLobby");

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