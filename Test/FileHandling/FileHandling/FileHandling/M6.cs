using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M6
    {
        static void Main(string[] args)
        {
            using (TextReader read = File.OpenText("data.txt"))
            {
                Console.WriteLine(read.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
