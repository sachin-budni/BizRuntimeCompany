using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M7
    {
        static void Main(string[] args)
        {
            using (TextReader read=File.OpenText("data.txt"))
            {
                Console.WriteLine(read.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
