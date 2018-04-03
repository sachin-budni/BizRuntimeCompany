using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M8
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("Binerydata.dat", FileMode.OpenOrCreate)))
            {
                bw.Write("sachin");
                bw.Write(56);
                bw.Write('d');
                bw.Write(25.3);
            }
            Console.WriteLine("create");
            Console.ReadKey();
        }
    }
}
