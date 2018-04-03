using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("first.txt",FileMode.OpenOrCreate);
            for(int i=65; i<=90; i++)
            {
                Console.Write((char)i);
                file.WriteByte((byte)i);
            }
            file.Close();
            Console.ReadKey();

        }
    }
}
