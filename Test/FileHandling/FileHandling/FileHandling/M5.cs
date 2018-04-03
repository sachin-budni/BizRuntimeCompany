using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M5
    {
        static void Main(string[] args)
        {
            using (TextWriter write = File.CreateText("data.txt"))
            {
                write.WriteLine("sachin *(");
                write.WriteLine("rjakdfjldgk)");
            }
            Console.WriteLine("file is written");
            Console.ReadKey();
        }
    }
}
