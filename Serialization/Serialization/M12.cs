using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class M12
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "sham";
            s1.Age = 21;

            Student s2 = new Student();
            s2.Id = 2;
            s2.Name = "raju";
            s2.Age = 24;

            Student s3 = new Student();
            s3.Id = 3;
            s3.Name = "shiva";
            s3.Age = 34;

            Student s4 = new Student();
            s4.Id = 4;
            s4.Name = "ranga";
            s4.Age = 35;
            
            ArrayList list = new ArrayList();
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);

            XmlSerializer serial = new XmlSerializer(typeof(Student));
            StreamWriter writer = new StreamWriter("FileXml.xml");
            //serial.Serialize(writer, list.);
            //serial.Serialize(writer, list);
            //serial.Serialize(writer, list);
            //serial.Serialize(writer, list);
            foreach(Student ss in list)
            {
                serial.Serialize(writer, ss);
            }
            Console.WriteLine("Good");
            
            writer.Close();
            Console.ReadKey();
        }
    }
}
