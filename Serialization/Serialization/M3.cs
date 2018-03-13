using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class C
    {
        public int i;
        public string s;
        public string m;
        public C(int i,string s,string m)
        {
            this.i = i;
            this.s = s;
            this.m = m;
        }
    }
    class M3
    {
        public static void test(C c1)
        {
            XmlSerializer serial = new XmlSerializer(typeof(C));
            using (TextWriter writer = new StreamWriter("obj1.xml"))
            {
                serial.Serialize(writer, c1);
            }
        }
        static void Main(string[] args)
        {
            C c1 = new C(20, "ranga", "madiwal");
            test(c1);
        }
    }
}
