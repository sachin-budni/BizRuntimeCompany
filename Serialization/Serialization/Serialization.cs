using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
    }
    class Serialization
    {
        Employee e1 = new Employee() { Id = 10, FirstName = "sachin", LastName = "Budni", Age = 21 };
        
        public void test6()
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(e1.GetType());
            MemoryStream stream = new MemoryStream();
            json.WriteObject(stream,e1);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            string s1=reader.ReadLine();
            Console.WriteLine(s1);
            Console.WriteLine("DataContractJsonSerializer from the Output");
            reader.Close();
            stream.Close();
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(s1)))
            {
                DataContractJsonSerializer json1 = new DataContractJsonSerializer(e1.GetType());
                Employee e2=(Employee)json1.ReadObject(ms);
                Console.WriteLine(e2.Id);
                Console.WriteLine(e2.FirstName);
                Console.WriteLine(e2.LastName);
                Console.WriteLine(e2.Age);
                Console.WriteLine();
            }
        }
        public void test5()
        {
            var serial = new JavaScriptSerializer();
            StreamReader read = new StreamReader("Three.json");
            string s1 = "";
            Employee e2 = null;
            while((s1=read.ReadLine())!=null)
            {
               e2 = serial.Deserialize<Employee>(s1);
            }
            Console.WriteLine(e2.Id);
            Console.WriteLine(e2.FirstName);
            Console.WriteLine(e2.LastName);
            Console.WriteLine(e2.Age);
            Console.WriteLine("-----------------------------------------");
        }
        public void test4()
        {
            var serial = new JavaScriptSerializer().Serialize(e1);
            StreamWriter writer = new StreamWriter("Three.json");
            string s2 = serial;
            writer.WriteLine(s2);
            Console.WriteLine(s2);
            Console.WriteLine("JSON Writting File");
            writer.Close();
        }
        public void test3()
        {
            XmlSerializer serial = new XmlSerializer(e1.GetType());
            StreamReader reader = new StreamReader("Second.xml");
            Employee e2=(Employee)serial.Deserialize(reader);
            Console.WriteLine(e2.Id);
            Console.WriteLine(e2.FirstName);
            Console.WriteLine(e2.LastName);
            Console.WriteLine(e2.Age);
            Console.WriteLine("-------------------------------------------");
            reader.Close();
        }
        public void test2()
        {
            XmlSerializer serial = new XmlSerializer(e1.GetType());
            StreamWriter writer = new StreamWriter("Second.xml");
            serial.Serialize(writer, e1);
            writer.Close();
            Console.WriteLine("XML File is Created");
        }
        public void test1()
        {
            FileStream f1 = new FileStream("First.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            Employee e2=(Employee)format.Deserialize(f1);
            Console.WriteLine(e2.Id);
            Console.WriteLine(e2.FirstName);
            Console.WriteLine(e2.LastName);
            Console.WriteLine(e2.Age);
            f1.Close();
            Console.WriteLine("------------------------------------------------------");

        }
        public void test()
        {
            FileStream FS = new FileStream("First.txt", FileMode.OpenOrCreate);
            
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(FS,e1);

            FS.Close();
            Console.WriteLine("File Convert into Binary Writting");
        }
        public void test7()
        {
            Employee ee1 = new Employee();
            ee1.Id = 2;
            ee1.FirstName = "rajiva";
            ee1.LastName = "shiva";
            ee1.Age = 23;

            Employee ee2 = new Employee();
            ee2.Id = 3;
            ee2.FirstName = "ranga";
            ee2.LastName = "ravi";
            ee2.Age = 95;

            ArrayList list = new ArrayList();
            list.Add(ee1);
            list.Add(ee2);

            FileStream stream = new FileStream("FileList.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, list);
            stream.Close();

            FileStream stream1 = new FileStream("FileList.txt", FileMode.OpenOrCreate);
            BinaryFormatter formate = new BinaryFormatter();
            ArrayList list1=(ArrayList)formate.Deserialize(stream1);
            foreach(Employee e in list1)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.LastName);
                Console.WriteLine(e.Age);
                Console.WriteLine();
            }
        }
        public void test8()
        {
            StreamReader reader = new StreamReader("First.txt");
            string s1 = "";
            while ((s1 = reader.ReadLine()) != null)
            {
                Console.WriteLine(s1);
            }
        }
        public void test9()
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

            var json = new JavaScriptSerializer().Serialize(list);
            StreamWriter writer = new StreamWriter("JsonList.json");
            Console.WriteLine(json);
            writer.WriteLine(json);
            writer.Close();
        }

        static void Main(string[] args)
        {
            Serialization s1 = new Serialization();
            s1.test();
            Console.WriteLine();
            s1.test1();
            Console.WriteLine();
            s1.test2();
            Console.WriteLine();
            s1.test3();
            Console.WriteLine();
            s1.test4();
            Console.WriteLine();
            s1.test5();
            Console.WriteLine();
            s1.test6();
            Console.WriteLine();
            s1.test7();
            Console.WriteLine();
            s1.test8();
            Console.WriteLine();
            s1.test9();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
