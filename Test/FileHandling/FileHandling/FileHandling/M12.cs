using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class M12
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("datas.txt", FileMode.Create);
            for(int i=65; i<=90; i++)
            {
                f1.WriteByte((byte)i);
            }
            f1.Close();
            Console.WriteLine("Writen");
            
            Console.ReadKey();
        }
    }
}
