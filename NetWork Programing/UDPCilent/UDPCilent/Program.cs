﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPCilent
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                IPAddress broadcast = IPAddress.Parse("192.168.1.255");
                string s1 = Console.ReadLine();
                char[] chars = s1.ToCharArray();
                byte[] sendbuf = Encoding.ASCII.GetBytes(chars);
                IPEndPoint ep = new IPEndPoint(broadcast, 11000);

                s.SendTo(sendbuf, ep);

                Console.WriteLine("Message sent to the broadcast address");
            }
            Console.ReadKey();
        }
    }
}
