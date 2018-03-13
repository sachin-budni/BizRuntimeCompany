using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class M8
    {
        static void Main(string[] args)
        {
            XmlSerializer serial = new XmlSerializer(typeof(Empl));
            StreamReader reader = new StreamReader("Object.xml");
            Empl empl = (Empl)serial.Deserialize(reader);
            Console.WriteLine(empl.Id);
            Console.WriteLine(empl.Name);
            Console.WriteLine(empl.Age);
            Console.WriteLine(empl.Address);
            Console.ReadKey();
        }
    }
}
