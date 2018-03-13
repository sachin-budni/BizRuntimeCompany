using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Serialization
{
    class M10
    {
        static void Main(string[] args)
        {
            Empl empl = new Empl()
            {
                Id=1,
                Name="sachin",
                Age=25,
                Address="near madiwal"
            };
            DataContractJsonSerializer data = new DataContractJsonSerializer(empl.GetType());
            MemoryStream stream = new MemoryStream();
            data.WriteObject(stream, empl);
            stream.Position = 0;
            StreamReader writer = new StreamReader(stream);
            string s1 = writer.ReadToEnd();
            Console.WriteLine(s1);
            writer.Close();
            stream.Close();
            using (MemoryStream stream1=new MemoryStream(Encoding.UTF8.GetBytes(s1)))
            {
                DataContractJsonSerializer data1 = new DataContractJsonSerializer(empl.GetType());
                Empl e1=(Empl)data1.ReadObject(stream1);
                Console.WriteLine(e1.Id);
                Console.WriteLine(e1.Name);
                Console.WriteLine(e1.Age);
                Console.WriteLine(e1.Address);
            }
            
            Console.ReadKey();
        }
    }
}
