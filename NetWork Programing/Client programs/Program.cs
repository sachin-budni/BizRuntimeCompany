using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClientProgram
{
    class Program
    {
        /// <summary>
        /// in this method we are executing client program
        /// if send any message it will send to server
        /// </summary>
        public static void Client()
        {
            TcpClient client = new TcpClient("192.168.1.39", 1200);
            Console.WriteLine("[try to connect to server]");
            NetworkStream s = client.GetStream();
            Console.WriteLine("[Connected]");
            string ch = Console.ReadLine();
            byte[] message = Encoding.Unicode.GetBytes(ch);
            s.Write(message, 0, message.Length);
            Console.WriteLine("-------------------------sent------------------------");
            client.Close();
        }
        /// <summary>
        /// main method start up execution
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Client();
            Console.ReadKey();
        }
    }
}
