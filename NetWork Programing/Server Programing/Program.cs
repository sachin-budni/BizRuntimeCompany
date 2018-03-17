using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listen = new TcpListener(IPAddress.Parse("192.168.1.39"), 1200);
            Console.WriteLine("Listening .....");
            listen.Start();
            TcpClient client = listen.AcceptTcpClient();
            Console.WriteLine("[Client is Connected]");
            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[client.ReceiveBufferSize];
            int data = stream.Read(buffer, 0, client.ReceiveBufferSize);
            string ch = Encoding.Unicode.GetString(buffer, 0, data);
            Console.WriteLine("Messages Recived :" + ch);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            client.Close();
            Console.ReadKey();
        }
    }
}
