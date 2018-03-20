using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace JSON
{
    [Serializable]
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* creatation of Object and values*/

            Employee e1 = new Employee();
            e1.Id = 1;
            e1.FirstName = "ramesh";
            e1.LastName = "shiva";
            e1.Age = 21;
            e1.Email = "ramesh@gmail.com";

            Employee e2 = new Employee();
            e2.Id = 2;
            e2.FirstName = "raju";
            e2.LastName = "sangu";
            e2.Age = 26;
            e2.Email = "raju@gmail.com";

            Employee e3 = new Employee();
            e3.Id = 3;
            e3.FirstName = "ranga";
            e3.LastName = "somu";
            e3.Age = 23;
            e3.Email = "ranga@gmail.com";

            object[] emp = {e1, e2, e3};

            /* file attempt using dataContractJsonSerializer ----------------------------------------------*/
            List<Employee> list4 = new List<Employee>();
            list4.Add(e1);
            list4.Add(e2);
            list4.Add(e3);

            DataContractJsonSerializer data = new DataContractJsonSerializer(list4.GetType());
            MemoryStream stream = new MemoryStream();
            data.WriteObject(stream, list4);
            stream.Position = 0;
            StreamReader reader1 = new StreamReader(stream);
            string s4 = reader1.ReadToEnd();
            Console.WriteLine(s4);
            stream.Close();
            reader1.Close();

            using (MemoryStream stream1 = new MemoryStream(Encoding.Default.GetBytes(s4)))
            {
                DataContractJsonSerializer data1 = new DataContractJsonSerializer(list4 .GetType());
                List<Employee> list12 = new List<Employee>();
                list12 = (List<Employee>)data1.ReadObject(stream1);
                foreach(var listss in list12)
                {
                    Console.WriteLine("ID :" + listss.Id);
                    Console.WriteLine("FIRSTNAME :" + listss.FirstName);
                    Console.WriteLine("LASTNAME :" + listss.LastName);
                    Console.WriteLine("AGE :" + listss.Age);
                    Console.WriteLine("EMAIL :" + listss.Email);
                    Console.WriteLine();
                }
            };
            Console.WriteLine("-----------------------------------------------------------------------------------");
                /* file attempt using newton jsonConverter ----------------------------------------------*/

                string output = JsonConvert.SerializeObject(emp);

            FileStream file = new FileStream("jsonConvert.json",FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(output);
            Console.WriteLine("JSON File is created");
            writer.Close();
            file.Close();

            FileStream file2 = new FileStream("jsonConvert.json", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file2);
            string s1=null;
            while((s1=reader.ReadLine())!=null)
            {    
                List<Employee> list = new List<Employee>();
                list = JsonConvert.DeserializeObject<List<Employee>>(output);
                foreach(var ed in list)
                {
                    Console.WriteLine("ID :"+ed.Id);
                    Console.WriteLine("FIRSTNAME :"+ed.FirstName);
                    Console.WriteLine("LASTNAME :"+ed.LastName);
                    Console.WriteLine("AGE :"+ed.Age);
                    Console.WriteLine("EMAIL :"+ed.Email);
                    Console.WriteLine();
                }
            }
            file2.Close();
            reader.Close();

            /* file attempt using Javascriptserializer -------------------------------------*/
            Console.WriteLine("-----------------------------------------------------------------------------------");

            var serial = new JavaScriptSerializer();
            string s2=serial.Serialize(emp);
            Console.WriteLine(s2);

            List<Employee> list1 = new List<Employee>();
                list1 = serial.Deserialize<List<Employee>>(s2);

            foreach(var lists in list1)
            {
                Console.WriteLine("ID :" + lists.Id);
                Console.WriteLine("FIRSTNAME :" + lists.FirstName);
                Console.WriteLine("LASTNAME :" + lists.LastName);
                Console.WriteLine("AGE :" + lists.Age);
                Console.WriteLine("EMAIL :" + lists.Email);
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
