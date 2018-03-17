using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    class M2
    {

        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(M3));

        /// <summary>
        /// i create the serverProgram 
        /// socket is combination of Address family sockettype protocol 
        /// and it bind with protocols and ip address
        /// </summary>
        public static void ServerProgram()
        {
            try
            {
                Console.WriteLine("Connecting .....");
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(IPAddress.Any, 2500));
                socket.Listen(100);
                Console.WriteLine("Connected");
                Socket accept = socket.Accept();
                byte[] buf = new byte[accept.SendBufferSize];
                string s = Encoding.Default.GetString(buf);
                Console.WriteLine(s);

                log.Info(s);

                string s1 = Console.ReadLine();
                //char[] c1=s1.ToCharArray();
                byte[] buffer = Encoding.Default.GetBytes(s1);
                //byte[] buff = Encoding.ASCII.GetBytes(s1);
                socket.Send(buffer, 0, buffer.Length, 0);
                log.Info(s1);
                Console.WriteLine("-----------------------------------sent-----------------------");
                socket.Close();
                accept.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                log.Error(e);
            }
        }
        static void Main(string[] args)
        {
            ServerProgram();
            Console.ReadKey();
        }
    }
}
