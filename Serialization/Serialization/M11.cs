using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class S
    {
        public int i;
        public string s;
    }
    class M11
    {
        static void Main(string[] args)
        {
            S s1 = new S();
            s1.i = 1;
            s1.s = "ramu";

            S s2 = new S();
            s2.i = 2;
            s2.s = "shiva";

            S s3 = new S();
            s3.i = 3;
            s3.s = "raju";

            ArrayList list = new ArrayList();
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            FileStream stream = new FileStream("Array.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream,list);
            stream.Close();
            Console.WriteLine("added");
            Console.WriteLine();

            FileStream stream1 = new FileStream("Array.txt", FileMode.OpenOrCreate);
            BinaryFormatter format1 = new BinaryFormatter();
            ArrayList slist=(ArrayList) format1.Deserialize(stream1);
            foreach(S ss in slist)
            {
                Console.WriteLine(ss.i);
                Console.WriteLine(ss.s);
            }
            Console.ReadKey();
        }
    }
}
