using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M1
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("first.txt",FileMode.OpenOrCreate);
            int i = 0;
            while((i=f1.ReadByte())!=-1)
            {
                Console.Write((char)i);
            }
            f1.Close();
            Console.ReadKey();
        }
    }
}
