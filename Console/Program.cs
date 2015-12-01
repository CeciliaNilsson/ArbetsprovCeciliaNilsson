using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Client();
        }

        static void Client()
        {
            using (TcpClient client = new TcpClient("192.168.202.59", 51111))

            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter w = new BinaryWriter(n);
                DBConnection dbConnection = new DBConnection();
                dbConnection.DatabaseConnection();
                w.Write("Här skriver du ditt meddelande, avsluta med Enter");
                dbConnection.addMessage(DateTime.Now, Console.ReadLine());
                Console.WriteLine(new BinaryReader(n).ReadString());
                w.Flush();
                dbConnection.CloseDatabaseConnection();
            }
        }
    }
}
