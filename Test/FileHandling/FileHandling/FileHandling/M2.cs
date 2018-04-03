using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M2
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("first.doc", FileMode.Create);
            StreamWriter sw = new StreamWriter(f1);
            sw.WriteLine("sachin Bundi");
            sw.WriteLine("sachin Bundi");
            sw.Close();
            f1.Close();
            Console.WriteLine("File is created");
            Console.ReadKey();
        }
    }
}
