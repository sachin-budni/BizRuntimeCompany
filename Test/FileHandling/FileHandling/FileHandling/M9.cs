using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M9
    {
        static void Main(string[] args)
        {
            using (BinaryReader br = new BinaryReader(File.Open("binerydata.dat", FileMode.OpenOrCreate)))
            {
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadChar());
                Console.WriteLine(br.ReadDouble());
            }
            Console.ReadKey();
        }
    }
}
