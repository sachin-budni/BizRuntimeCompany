using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysGenerics
{
    // Generic //
    class A<T>
    {
        public A(T Mgs)
        {
            Console.WriteLine("I Am From A class Constructor :" + Mgs);
        }
        public T Test(T Mgs)
        {
            return Mgs;
        }
    }
    class B<R,S>
    {
        public B(R r1,S s1)
        {
            Console.WriteLine("I Am form B class Constructor:{0},{1}",r1,s1);
        }
        public B(S s1)
        {
            Console.WriteLine("I am from B class Constroctor :"+s1);
        }
    }
    class C
    {
        public void Test<T>(T Mgs)
        {
            Console.WriteLine("I Am from C Class :" + Mgs);
        }
        public void Test1<S>(S s1,S s2,S s3)
        {
            Console.WriteLine(s1 + ", " + s2 + ", " + s3);
        }
        public void Test<U,V>(U u1,V v1)
        {
            Console.WriteLine(u1 + "   " + v1);
        }
    }

    class ArrayGeneric
    {
        //Arrays start
        public static void MinElement(int[] Arr)
        {
            int Min = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (min > Arr[i])
                {
                    min = Arr[i];
                }
            }
            Console.WriteLine(Min);
        }
        public static void MaxElement(int[] Arr)
        {
            int Max = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Max < Arr[i])
                {
                    Max = Arr[i];
                }
            }
            Console.WriteLine(Max);
        }
        public static void PrintArray3(int[][] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public static void Test3()
        {
            int[][] Arr = new int[3][];
            Arr[0] = new int[4] { 7, 8, 9, 6 };
            Arr[1] = new int[2] { 4, 5 };
            Arr[2] = new int[5] { 7, 8, 9, 9, 7 };
            PrintArray3(Arr);
        }
        public static void PrintArray2(int[,] Arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public static void Test2()
        {
            //int[,] arr=new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //int[,] arr = new int[3, 3];
            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[0, 2] = 3;
            //arr[1, 0] = 4;
            //arr[1, 1] = 5;
            //arr[1, 2] = 6;
            //arr[2, 0] = 7;
            //arr[2, 1] = 8;
            //arr[2, 2] = 9;

            int[,] Arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            PrintArray2(Arr);
        }
        public static void PrintArray(int[] Arr)
        {
            foreach (Object Ele in Arr)
            {
                Console.Write(Ele + " ");
            }
        }
        public static void Test()
        {
            int[] Arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            int[] Arr2 = new int[6];
            Console.WriteLine("length of first array: " + Arr.Length);

            Array.Sort(Arr);
            Console.Write("First array elements:");
            PrintArray(Arr);

            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(Arr, 25));

            Array.Copy(Arr, Arr2, Arr.Length);
            Console.Write("Second array elements: ");
            PrintArray(Arr2);

            Array.Reverse(Arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(Arr);
        }
        public static void SortingElement(int[] Arr)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            Console.Write("Sorting Arrays :");
            PrintArray(Arr);
        }
        static void Main(string[] args)
        {
            //generics
            A<string> a1 = new A<string>("sachin");
            a1.Test("ravi");
            Console.WriteLine();

            B<int, string> b1 = new B<int, string>(25, "ranga");
            B<string, string> b2 = new B<string, string>("shivaji", "shinu");
            Console.WriteLine();

            C c1 = new C();
            c1.Test(25);
            c1.Test1("tajfk","kdjfk","dkfd");
            c1.Test(25, 85);
            Console.ReadKey();
            
            //Arrays

            Test();
            Console.WriteLine();
            Test2();
            Console.WriteLine();
            Test3();

            int[] arr = new int[8] { 25, 78, 85, 45, 52, 36, 54, 55 };
            Console.WriteLine(arr.Length);
            MinElement(arr);
            MaxElement(arr);
            SortingElement(arr);
            Console.Read();
        }
    }
}
