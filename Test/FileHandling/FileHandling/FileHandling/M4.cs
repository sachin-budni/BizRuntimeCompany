using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M4
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("first.doc", FileMode.OpenOrCreate);
            FileStream f2 = new FileStream("sec.html", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f1);
            StreamWriter sw = new StreamWriter(f2);
            string line = "";
            while((line=sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
                sw.WriteLine(line);
            }
            sw.Close();
            sr.Close();
            f1.Close();
            f2.Close();
            Console.WriteLine("file is created");
            Console.ReadKey();
        }
    }
}
