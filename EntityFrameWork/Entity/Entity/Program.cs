using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleEntities sample=new SampleEntities())
            {
                //sample.Addresses.Add(new Address() { Id = 1,Name="sapna" });
                //sample.Addresses.Add(new Address() { Id = 2,Name="sachin" });

                //Address a1=sample.Addresses.FirstOrDefault(c => c.Name == "sachin");
                //Console.WriteLine("Data is Added"+a1.Id);

                //sample.People.Add(new Person() { Id = 1,Name="rajiv",Age=23,Address_Id=a1.Id });

                //sample.People.Add(new Person() { Id = 2,Name="rajiv",Age=23, Address_Id = a1.Id });
                //sample.SaveChanges();

                List<Person> lists = sample.People.ToList();
                foreach(var list in lists)
                {
                    Console.WriteLine(list.Id+" ,"+list.Name+" ,"+list.Age+" ,"+list.Address.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
