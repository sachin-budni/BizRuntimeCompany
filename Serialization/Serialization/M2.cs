using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    //[Serializable]
    class B
    {
        public int i;
        public string s;
        public B(int i,string s)
        {
            this.i = i;
            this.s = s;
        }
    }
    class M2
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("obj.txt", FileMode.OpenOrCreate);
            BinaryFormatter formate = new BinaryFormatter();
            A b1 = (A)formate.Deserialize(stream);
            Console.WriteLine("i = "+b1.i);
            Console.WriteLine("s = "+b1.s);
            stream.Close();
            Console.ReadKey();
        }
    }
}
