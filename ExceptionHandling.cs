using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class InvalidedTempException:Exception
    {
        public InvalidedTempException(string s2):base(s2)
        {

        }
    }
    class InvalidedAgeException:Exception
    {
        public InvalidedAgeException(string s1):base(s1)
        {

        }
    }

    class ExceptionHandling
    {
        public static void test9()
        {
            int i = 102;
            int j = 0;
            int k = 0;
            try
            {
                k = i / j;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is must execute");
            }
            Console.WriteLine("Rest of the Code Execute");
        }
        public static void test8()
        {
            int i = 102;
            int j = 0;
            int k = 0;
            try
            {
                k = i / j;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is must execute");
            }
            Console.WriteLine("Rest of the Code Execute");
        }
        public static void test7()
        {
            try
            {
                int[] i = new int[99999999999999];
                i[10] = 89;
                Console.WriteLine(i[2]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest Of the Code");
        }
        public static void test6()
        {
            int[] i = new int[99999999999999];
            i[10] = 89;
            Console.WriteLine(i[2]);
        }
        public static void test5()
        {
            int[] i = new int[5];
            try
            {
                i[10] = 89;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("rest Of the Code");
        }
        public static void test4()
        {
            int[] i = new int[5];
            i[10] = 10;
            Console.WriteLine(i[10]);
        }
        public static void test3()
        {
            int Temp = 0;
            if(Temp==0)
            {
                throw new InvalidedTempException("Temperatur is Zero");
            }
            else
            {
                Console.WriteLine("Temperatur :{0}", Temp);
            }
        }
        public static void test2()
        {
            int age = 12;
            if(age<18)
            {
                throw new InvalidedAgeException("age is Less than 18");
            }
            else
            {
                Console.WriteLine("Age :{0}", age);
            }
        }
        public static void test1()
        {
            int i = 12;
            int j = 0;
            int k = 0;
            try
            {
                k = i / j;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("rest Of the Code");
        }
        public static void test()
        {
            int i = 1;
            int j = 0;
            int k = 0;
            k = i / j;
            Console.WriteLine(k);
        }
        static void Main(string[] args)
        {
            //test();
            Console.WriteLine("-----------------------");

            test1();
            Console.WriteLine("-----------------------");

            test2();
            Console.WriteLine("-----------------------");
            try
            {
                test3();
            }
            catch(InvalidedTempException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("rest If the Code");
            Console.WriteLine("-----------------------");

            test4();
            Console.WriteLine("---------------------------");

            test5();
            Console.WriteLine("-------------------------");

            test6();
            Console.WriteLine("--------------------------");

            test6();
            Console.WriteLine("--------------------------");

            test7();
            Console.WriteLine("--------------------------");

            test8();
            Console.WriteLine("-------------------------");

            test9();
            Console.WriteLine("-------------------------");

            Console.ReadKey();
        }
    }
}
