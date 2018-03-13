using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class A
    {
        public int i;
        public string s;
        public A(int i,string s)
        {
            this.i = i;
            this.s = s;
        }
    }
    class M1
    {
        static void Main(string[] args)
        {
            A a1 = new A(1, "raju");
            FileStream stream = new FileStream("obj.txt", FileMode.OpenOrCreate);
            BinaryFormatter formate = new BinaryFormatter();
            formate.Serialize(stream, a1);
            stream.Close();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
