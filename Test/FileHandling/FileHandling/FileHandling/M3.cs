using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M3
    {
        static void Main(string[] args)
        {
            FileStream f1 = new System.IO.FileStream("first.txt",FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f1);
            string s1 = sr.ReadLine();
            Console.WriteLine(s1);
            sr.Close();
            f1.Close();
            Console.ReadKey();
        }
    }
}
