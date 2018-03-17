using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    class M1
    {
        static void Main(string[] args)
        {
            Socket skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("Connecting");
            skt.Bind(new IPEndPoint(IPAddress.Any, 1994)); // Servers must bind a socket to an address to establish a local name
            Console.WriteLine("Connected");
            skt.Listen(0); // 

            Socket accept = skt.Accept(); // A socket accepts an incoming request by leaving a new socket, that can be used to read and write to the client.
            byte[] byt = new byte[accept.SendBufferSize];
            Console.WriteLine("recived :->", Encoding.Unicode.GetString(byt));

            byte[] buffer = Encoding.Default.GetBytes("Hie client");
            accept.Send(buffer, 0, buffer.Length, 0);

            buffer = new byte[255];
            int rec = accept.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);
            skt.Close();
            accept.Close();// when a connection has finished its session, a socket must be closed that releases all the resources held by the socket.

            Console.ReadKey();
        }
    }
}
