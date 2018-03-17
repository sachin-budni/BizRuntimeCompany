using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientProgram
{
    class M3
    {
        /// <summary>
        /// its client program 
        /// its is connect to server program
        /// if i send the any message 
        /// its server will recieve that message
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(M3));

        public static void ClientProgram()
        {
            try
            {
                Socket skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.1.39"), 1994);
                skt.Connect(ipep);

                Console.Write("Enter the Message             :  ");

                string msg = Console.ReadLine();
                log.Info("Sent To Server Message :"+DateTime.Now.ToLongTimeString()+" \t\t  "+msg);
                byte[] msgbuffer = Encoding.Default.GetBytes(msg);
                skt.Send(msgbuffer, 0, msgbuffer.Length, 0);


                byte[] buffer = new byte[255];
                int rec = skt.Receive(buffer, 0, buffer.Length, 0);
                Array.Resize(ref buffer, rec);
                Console.WriteLine(Encoding.Default.GetString(buffer));
                log.Info("From Server Message :"+DateTime.Now.ToLongTimeString()+"\t\t"+Encoding.Default.GetString(buffer));
                skt.Close();
                ClientProgram();
            }
            catch(Exception e)
            {
                log.Error(e);
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// it is main method start up the program
        /// in this method it will calls the clientprogram
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClientProgram();
            Console.ReadKey();
        }
    }
}
