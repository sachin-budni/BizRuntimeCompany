using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    class M3
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(M3));
        /// <summary>
        /// its serverprograming method
        /// in this method Servers must bind a socket to an address to establish a local name
        ///  A socket accepts an incoming request by leaving a new socket, that can be used to read and write to the client.
        ///  when a connection has finished its session, a socket must be closed that releases all the resources held by the socket.
        /// </summary>
        public static void ServerProgram()
        {
            try
            {
                Socket skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("Connecting ....");
                
                skt.Bind(new IPEndPoint(IPAddress.Any, 1994));
                skt.Listen(0);

                Socket accept = skt.Accept();
                Console.WriteLine("Connected");
                byte[] byt = new byte[accept.SendBufferSize];
                int words = accept.Receive(byt);
                byte[] formated = new byte[words];
                for (int i = 0; i < words; i++)
                {
                    formated[i] = byt[i];
                }
                string strdata = Encoding.ASCII.GetString(formated);
                Console.WriteLine(strdata);
                log.Info("From Client Message :"+ DateTime.Now.ToLongTimeString() + "\t\t "+ strdata);

                string s2 = Console.ReadLine();
                byte[] buffer = Encoding.Default.GetBytes(s2);
                //  byte[] buffer = Encoding.Default.GetBytes("Hi client");
                log.Info("Sent to Client Message :" + DateTime.Now.ToLongTimeString() + " \t\t" + s2);

                accept.Send(buffer, 0, buffer.Length, 0);
                buffer = new byte[255];
                int rec = accept.Receive(buffer, 0, buffer.Length, 0);
                Array.Resize(ref buffer, rec);
                skt.Close();
                accept.Close();
                ServerProgram();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                log.Error(e);
            }
        }
        /// <summary>
        /// its main method start up program 
        /// inside severprogram methos is calling 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ServerProgram();
            Console.ReadKey();
        }
    }
}
