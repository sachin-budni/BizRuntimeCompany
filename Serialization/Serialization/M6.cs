using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class B1
    {
        public int i;
        public string s;
    }
    class M6
    {
        public static void test(B1 b1)
        {
            XmlSerializer serial = new XmlSerializer(b1.GetType());
            using (TextWriter writer = new StreamWriter("jhhdf.xml"))
            {
                serial.Serialize(writer, b1);
            }
        }
        static void Main(string[] args)
        {
            B1 b1 = new B1();
            b1.i = 20;
            b1.s = "ramjfk";
            test(b1);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
