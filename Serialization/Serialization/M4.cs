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
    public class Emp
    {
        public int Id;
        public string Name;
        public int Age;
    }
    class M4
    {
        public static void test(Emp emp)
        {
            XmlSerializer serializer = new XmlSerializer(emp.GetType());
            StreamWriter writer = new StreamWriter("Obje.xml");
            serializer.Serialize(writer, emp);
            writer.Close();
        }
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.Id = 1;
            emp.Name = "sham";
            emp.Age = 35;
            test(emp);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
