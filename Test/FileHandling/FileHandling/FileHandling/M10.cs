using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M10
    {
        static void Main(string[] args)
        {
            string text = "dsjkjfkfkjkfjskjkfdjkd";
            StringBuilder br = new StringBuilder();
            StringWriter sw = new StringWriter(br);
            sw.Write(text);
            sw.Flush();
            sw.Close();
            StringReader sr = new StringReader(br.ToString());
            while(sr.Peek()> -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.Read();
        }
    }
}
