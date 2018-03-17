using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClientProgram
{
    class M1
    {
        static void Main(string[] args)
        {
            Socket skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.1.39"), 1994); // it is combination of IP + Port address 

            skt.Connect(ipep);// once a socket is connected to an end point, sending data initiates a message that the other point is then able to receive.
            Console.Write("Enter the MSg:->");

            string msg = Console.ReadLine();
            byte[] msgbuffer = Encoding.Default.GetBytes(msg);

            skt.Send(msgbuffer, 0, msgbuffer.Length, 0);// once a socket is connected to an end point, sending data initiates a message that the other point is then able to receive.

            byte[] buffer = new byte[255];
            int rec = skt.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);

            Console.WriteLine("recived {0}", Encoding.Default.GetString(buffer));

            skt.Close();

            Console.ReadKey();
        }
    }
}
