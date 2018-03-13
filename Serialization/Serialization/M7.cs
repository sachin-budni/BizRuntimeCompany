using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class M7
    {
        public static void test(Empl empl)
        {
            XmlSerializer serial = new XmlSerializer(empl.GetType());
            using (TextWriter writer = new StreamWriter("Object.xml"))
            {
                serial.Serialize(writer, empl);
            }
        }
        static void Main(string[] args)
        {
            Empl empl = new Empl();
            empl.Id = 1;
            empl.Name = "raju";
            empl.Age = 21;
            empl.Address = "near Madiwal Police station";
            test(empl);
            Console.WriteLine("Done");
            Console.ReadKey();  
        }
    }
}
