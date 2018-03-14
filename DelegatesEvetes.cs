using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    public delegate void Tested(string s);
    public delegate string Tested1(string s);
    public delegate double Tested2(int i,double d);

    class A1
    {
        public Tested First;
        public void test3(string s)
        {
            Console.WriteLine("Wel Come "+s);
        }
        public void test(string s)
        {
            Console.WriteLine(s);
        }
        public string test1(string s)
        {
            return s;
        }
        public double test2(int i,double d)
        {
            return i + d;
        }
    }
    class DelegatesEvetes
    {
        public static void test()
        {
            A1 a1 = new A1();
            a1.test("ravi");
            string s = a1.test1("shiva");
            double d = a1.test2(25, 3.5);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        public static void test1()
        {
            A1 a1 = new A1();
            Tested tests = new Tested(a1.test);
            tests.Invoke("ravi");
            Tested1 tests1 = new Tested1(a1.test1);
            string s=tests1.Invoke("shiva");
            Tested2 tests2 = new Tested2(a1.test2);
            double d=tests2.Invoke(25, 25.30);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        public static void test2()
        {
            A1 a1 = new A1();
            Tested tests = a1.test;
            tests.Invoke("ravi");
            Tested1 tests1 = a1.test1;
            string s=tests1.Invoke("shiva");
            Tested2 tests2 = a1.test2;
            double d=tests2.Invoke(25,25.5);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        public static void test3()
        {
            A1 a1 = new A1();
            Tested tests = delegate (string s1)
            {
                Console.WriteLine(s1);
            };
            tests.Invoke("ravi");

            Tested1 tests1 = delegate(string s2)
            {
                return s2;
            };
            string s = tests1.Invoke("shiva");

            Tested2 tests2 = delegate(int i,double b)
            {
                return i + b;
            };
            double d = tests2.Invoke(25, 25.5);

            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        public static void test4()
        {
            A1 a1 = new A1();
            Tested tests = (s1) =>
            {
                Console.WriteLine(s1);
            };
            tests.Invoke("ravi");

            Tested1 tests1 = (s2)=>
            {
                return s2;
            };
            string s = tests1.Invoke("shiva");

            Tested2 tests2 = (i,b)=>
            {
                return i + b;
            };
            double d = tests2.Invoke(25, 25.5);

            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        public static void test5()
        {
            A1 a1 = new A1();
            Action<string> test = new Action<string>(a1.test);
            test.Invoke("ravi");
            Func<string, string> test1 = new Func<string, string>(a1.test1);
            string s=test1.Invoke("shiva");
            Func<int, double,double> test2 = new Func<int, double, double>(a1.test2);
            double d=test2.Invoke(25, 23.5);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        public static void test6()
        {
            A1 a1 = new A1();
            a1.First += new Tested(a1.test3);
            string s;
            do
            {
                s = Console.ReadLine();
                if(s.ToUpper()!="NO")
                {
                    a1.First(s);
                }
            } while (s.ToUpper() != "NO");
        }
        static void Main(string[] args)
        {
            test();
            Console.WriteLine();

            test1();
            Console.WriteLine();

            test2();
            Console.WriteLine();

            test3();
            Console.WriteLine();

            test4();
            Console.WriteLine();

            test5();
            Console.WriteLine();

            test6();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
