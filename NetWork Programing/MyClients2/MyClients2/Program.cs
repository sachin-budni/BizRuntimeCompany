using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyClients2
{
    class Program
    {
        TcpClient clientSocket = new TcpClient("192.168.1.52", 1000);
        public void Write()
        {

            while (true)
            {
                string str = Console.ReadLine();
                NetworkStream stream = clientSocket.GetStream();
                char[] chars = str.ToCharArray();
                byte[] byte_count = Encoding.Default.GetBytes(chars);
                //BinaryWriter writer = new BinaryWriter(clientSocket.GetStream());
                //writer.Write(str);
                stream.Write(byte_count, 0, byte_count.Length);
            }
        }
        public void Read()
        {
            while (true)
            {
                //TcpClient clientSocket = new TcpClient("192.168.1.12", 1000);
                NetworkStream stream = clientSocket.GetStream();

                byte[] buffer = new byte[1024];
                int byte_count = 0;
                try
                {
                    byte_count = stream.Read(buffer, 0, buffer.Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                byte[] formated = new Byte[byte_count];
                Array.Copy(buffer, formated, byte_count);
                string data = Encoding.ASCII.GetString(formated);

                Console.WriteLine(data);
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Thread ctThread = new Thread(p1.Write);
            Thread ctThread2 = new Thread(p1.Read);
            ctThread.Start();
            ctThread2.Start();
        }
    }
}
