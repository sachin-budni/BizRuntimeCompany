using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Sunday
    {
        public int Id;
        public string Name;
    }
    class M5
    {
        public static void test(Sunday a1)
        {
            XmlSerializer serial = new XmlSerializer(a1.GetType());
            StreamWriter writer = new StreamWriter("obhdf.xml");
            serial.Serialize(writer, a1);
        }
        static void Main(string[] args)
        {
            Sunday a1 = new Sunday();
            a1.Id = 24;
            a1.Name = "skdjf";
            test(a1);
            Console.WriteLine(a1.GetType());
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
