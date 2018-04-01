using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyServer1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener ServerSocket = new TcpListener(1000);
            ServerSocket.Start();
            List<TcpClient> clients = new List<TcpClient>();
            Console.WriteLine("Server started.");
            while (true)
            {
                TcpClient clientSocket = ServerSocket.AcceptTcpClient();
                Console.WriteLine("Connected");
                handleClient client = new handleClient();
                clients.Add(clientSocket);
                client.startClient(clientSocket, clients);
            }
        }

        public class handleClient
        {
            TcpClient clientSocket;
            NetworkStream stream = null;
            public void startClient(TcpClient inClientSocket, List<TcpClient> clients)
            {
                //foreach(var client in clients)
                //{ 
                //    Console.WriteLine(client.GetHashCode());
                //}
                this.clientSocket = inClientSocket;
                var ctThread = new System.Threading.Thread(() => Chat(clients));
                var t1 = new System.Threading.Thread(()=>write(clients));
                ctThread.Start();
                t1.Start();
            }
            public void Chat(List<TcpClient> clients)
            {
                while (true)
                {
                    int i = clientSocket.GetHashCode();
                   
                    stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024*5000];
                    int byte_count = 0;
                    try
                    {
                        byte_count = stream.Read(buffer, 0, buffer.Length);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    //Console.WriteLine(byte_count);

                    byte[] formated = new byte[byte_count];

                    Array.Copy(buffer, formated, byte_count);

                    foreach (TcpClient client in clients)
                    {
                        if (client.GetHashCode() != i)
                        {
                            stream = client.GetStream();
                            //char[] chars = data.ToCharArray();
                            //byte[] byte_counts = Encoding.Default.GetBytes(chars);
                            stream.Write(formated, 0, formated.Length);
                        }
                    }

                    //string data = Encoding.ASCII.GetString(formated);
                    ////BinaryReader reader = new BinaryReader(clientSocket.GetStream());
                    ////BinaryWriter writer = new BinaryWriter(clientSocket.GetStream());
                    //Console.WriteLine(data);

                    //foreach (TcpClient client in clients)
                    //{
                    //    if (client.GetHashCode() != i)
                    //    {
                    //        stream = client.GetStream();
                    //        char[] chars = data.ToCharArray();
                    //        byte[] byte_counts = Encoding.Default.GetBytes(chars);
                    //        stream.Write(byte_counts, 0, byte_counts.Length);
                    //    }
                    //}
                }
            }
            public void write(List<TcpClient> Clients)
            {
                while (true)
                {
                    string data = Console.ReadLine();
                    foreach (TcpClient client in Clients)
                    {
                        stream = client.GetStream();
                        char[] chars = data.ToCharArray();
                        byte[] byte_count = Encoding.Default.GetBytes(chars);
                        stream.Write(byte_count, 0, byte_count.Length);
                    }
                }
            }
        }
    }
}
