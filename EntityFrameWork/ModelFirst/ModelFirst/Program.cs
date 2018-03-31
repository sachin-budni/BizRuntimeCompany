using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModelFirstContainer m1 = new ModelFirstContainer())
            {
                Home h1 = m1.Homes.FirstOrDefault(c => c.Name == "BTM");
                Console.WriteLine(h1.Id);
                //m1.Homes.Remove(h1);
                //m1.Homes.Add(new Home() {Name = "BTM" });
                //m1.People.Add(new Person() { Id = 1, Name = "raju", Home = h1 });
                List<Person> lists = m1.People.ToList<Person>();
                //m1.SaveChanges();
                foreach(var list in lists)
                {
                    Console.WriteLine(list.Id+" "+list.Name+" "+list.Home.Id+" "+list.Home.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
