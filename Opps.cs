using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class A
    {
        string Name;
        int age;
        int salary;
        //args constructor without static
        public A(string Name, int age, int salary)
        {
            this.Name = Name;
            this.age = age;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Emp Name :" + Name + "\n" + "Emp Age :" + age + "\n" + "Emp salary :" + salary + "\n");
        }
    }
    //-----------------------------------------------------------------------------
    class B
    {
        public string Name;
        int Age;
        public static int Salary;
        public static int count=0;
        //args constructor with static

        public void Get(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
            count++;
        }
        public void display()
        {
            Salary += 600;
            Console.WriteLine("Emp Name :" + Name + "\n" + "Emp Age :" + Age + "\n" + "Emp salary :" + Salary + "\n"+count);
        }
    }
    //------------------------------------------------------------------------------------
    class C
    {
        public C()
        {
            Console.WriteLine("Form C Class Constructor");
        }
        public void test()
        {
            Console.WriteLine("From C to test");
        }
        public virtual void test1()
        {
            Console.WriteLine("From overiden");
        }
    }
    //-------------------------------------------------------------------------------------------
    class D : C
    {
        public override void test1()
        {
            Console.WriteLine("From D class Overriding");
        }
        public void test1(int i)
        {
            Console.WriteLine(" from D Class OverLoading");
        }
    }
    //---------------------------------------------------------------------------------------------------------------
    interface E
    {
        void test2();
        void test3();
    }
    //------------------------------------------------------------------------------------------------------------------
    class F
    {
        public string Name
        {
            get;
            set;
        }
        
        public int Age
        {
            get;
            set;
        }
        public int Salary
        {
            get;
            set;
        }
    }
    //------------------------------------------------------------------------------------------------------
    class Opps:C,E
    {
        public void test2()
        {
            Console.WriteLine("Interface");
        }
        public void test3()
        {
            Console.WriteLine("From Second interface");
        }
        public enum session
        {
            sun,mon,tues,wed
        }
        Opps():this(25)
        {
            Console.WriteLine("From Opps class");
        }
        Opps(int i):base()
        {
            Console.WriteLine("goos");
        }
        static void Main(string[] args)
        {
            A a1 = new A("sachin",21,25000);
            a1.display();
            Console.WriteLine();

            B b1 = new B();
            b1.Get("ramu", 25);
            B.Salary = 2400;
            b1.display();
            Console.WriteLine();

            B b2 = new B();
            b2.Get("shiva", 23);
            B.Salary = 4500;
            b2.display();
            Console.WriteLine();

            int sun = (int)session.sun;
            int wed = (int)session.wed;
            session s1 = session.tues;
            Console.WriteLine(s1);
            Console.WriteLine(sun);
            Console.WriteLine(wed);
            Console.WriteLine();

            C c1 = new C();
            Console.WriteLine();

            Opps o = new Opps();
            o.test2();
            o.test3();
            Console.WriteLine();

            D d1 = new D();
            d1.test();
            d1.test1();
            d1.test1(32);
            Console.WriteLine();

            F f1 = new F();
            f1.Name = "Ravi";
            f1.Age = 36;
            f1.Salary = 80000;

            Console.WriteLine("Name :"+f1.Name);
            Console.WriteLine("Age :"+f1.Age);
            Console.WriteLine("Salary :"+f1.Salary);

            Console.Read();
        }

        
    }
}
