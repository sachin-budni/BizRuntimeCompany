using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    interface C1
    {
        void test();
    }
    class D1:C1
    {
        public void test()
        {
            Console.WriteLine("From D1 test");
        }
    }
    class E1:C1
    {
        public void test()
        {
            Console.WriteLine("From E1 test");
        }
    }
    interface B1
    {
        void test4();
        void test3();
    }
    abstract class A1
    {
        public int i;
        public string s1;
        public abstract void test();
        public virtual void test1()
        {
            Console.WriteLine("abstract class Method from test1");
        }
        public void test2()
        {
            Console.WriteLine(i + "  " + s1);
            Console.WriteLine("Abstract method from test2");
        }
        public virtual void test3()
        {
            Console.WriteLine("abstract test3");
        }
        public abstract void test4();
    }
    class AbstractInterface:A1,B1
    {
        public override void test4()
        {
            Console.WriteLine("from main to test4");
        }
        public override void test3()
        {
            base.test3();
            Console.WriteLine("Main method test3");
        }
        public override void test1()
        {
            base.test1();
            Console.WriteLine("Main class Method");
        }
        public override void test()
        {
            Console.WriteLine("abstract method impl in main class");
        }
        static void Main(string[] args)
        {
            A1 a1 = new AbstractInterface();
            a1.test();
            a1.test1();
            a1.i = 10;
            a1.s1 = "sachin";
            a1.test2();
            a1.test3();
            a1.test4();
            Console.WriteLine();
            AbstractInterface ab = new AbstractInterface();
            ab.test4();
            ab.test2();
            Console.WriteLine();
            B1 b1 = new AbstractInterface();
            b1.test4();
            b1.test3();
            Console.WriteLine();
            ArrayList list = new ArrayList();
            list.Add(new D1());
            list.Add(new E1());
            //C1 c1=null;
            foreach(C1 c1 in list)
            {
                c1.test();
            }
            Console.ReadKey();
        }
    }
}
