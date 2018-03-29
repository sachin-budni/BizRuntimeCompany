using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleEntities sample=new SampleEntities())
            {
                //Simple s1 = new Simple() { Name="raju"};
                //Simple s2 = new Simple() { Name="ramu"};
                //Simple s3 = new Simple() { Name="shiva"};
                //Simple s4 = new Simple() { Name="shankar"};
                //Simple s5 = new Simple() { Name="mallu"};
                //sample.Simples.Add(s1);
                //sample.Simples.Add(s2);
                //sample.Simples.Add(s3);
                //sample.Simples.Add(s4);
                //sample.Simples.Add(s5);
                //Simple s1 = sample.Simples.FirstOrDefault(r => r.Name == "raju");
                //sample.Simples.Remove(s1);
                //s1.Name = "Ninga";
                //Simple s1 = sample.Simples.FirstOrDefault(r => r.Name == "Ninga");
                //Console.WriteLine(s1.Id);
                List<Simple> lists= sample.Simples.ToList();
                foreach(var list in lists)
                {
                    Console.WriteLine(list.Id + "  " + list.Name);
                }
                sample.Simples.ToArray();
                //sample.SaveChanges();
                Console.ReadKey();
            }
        }
    }
}
