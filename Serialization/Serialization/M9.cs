using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace Serialization
{
    public class MyDate
    {
        public int year;
        public int month;
        public int day;
    }
    public class Lad
    {
        public string firstName;
        public string lastName;
        public MyDate dateOfBirth;
    }
    class M9
    {
        static void Main(string[] args)
        {
            var obj = new Lad
            {
                firstName = "sachin",
                lastName = "Bundi",
                dateOfBirth = new MyDate
                {
                    year = 1993,
                    month = 4,
                    day = 30
                }
            };
            var json = new JavaScriptSerializer().Serialize(obj);
            StreamWriter writer = new StreamWriter("Jsonss.json");
            Console.WriteLine(json);
            writer.Write(json);
            writer.Close();

            var json1 = new JavaScriptSerializer();
            StreamReader reader = new StreamReader("Jsonss.json");
            string s1 = "";
            Lad Obj1 = null;
            while ((s1 = reader.ReadLine()) != null)
            {
                Obj1 = new JavaScriptSerializer().Deserialize<Lad>(s1);
            }
            Console.WriteLine(Obj1.firstName);
            Console.WriteLine(Obj1.lastName);
            Console.WriteLine(Obj1.dateOfBirth.year);
            Console.WriteLine(Obj1.dateOfBirth.month);
            Console.WriteLine(Obj1.dateOfBirth.day);
            Console.ReadKey();
        }
    }
}
