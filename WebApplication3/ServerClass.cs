using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Web;

namespace WebApplication3
{
    public class ServerClass
    {
        static public List<Message> messages = new List<Message>();

        public void Main()
        {
            new Thread(Server).Start();
            Thread.Sleep(500);
            Console.ReadKey();
        }

        static void Server()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 51111);
            listener.Start();
            using (TcpClient c = listener.AcceptTcpClient())
            using (NetworkStream n = c.GetStream())
            {
                string msg = new BinaryReader(n).ReadString();
                BinaryWriter w = new BinaryWriter(n);

                w.Flush();
            }
            listener.Stop();
        }
    }
}