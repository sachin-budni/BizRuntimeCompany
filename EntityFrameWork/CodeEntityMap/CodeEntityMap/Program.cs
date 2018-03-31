using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEntityMap
{
    public class Student1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        public virtual Address1 Address { get; set; }
    }
    public class Address1
    {
        public Address1()
        {
            this.Student = new HashSet<Student1>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student1> Student { get; set; }
    }
    public class StudentAddress:DbContext
    {
        public StudentAddress():base("name=StudentAddress")
        {

        }
        public DbSet<Student1> Students { get; set; }
        public DbSet<Address1> Addresses { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentAddress s1=new StudentAddress())
            {
                //s1.Addresses.Add(new Address1() { Id = 2, Name = "BTM" });
                //s1.SaveChanges();

                Address1 a1 = s1.Addresses.FirstOrDefault(c=>c.Name=="BTM");
                Console.WriteLine(a1.Id);
               
                //s1.Students.Add(new Student1() { Id = 1, FirstName = "shiva", LastName = "raghu", Age = 32, Address = a1 });
                //s1.SaveChanges();
                //Console.WriteLine("added the data");

                List<Student1> lists = s1.Students.ToList<Student1>();
                foreach(var list in lists)
                {
                    Console.WriteLine(list.Id + " " + list.FirstName + "  " + list.LastName + "  " + list.Age + "  " + list.Address.Id + "  " + list.Address.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
