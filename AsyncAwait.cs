using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class AsyncAwait
    {

        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(M5));
        public static int test1()
        {
            int count = 0;
            try
            {
                FileStream file = new FileStream("test.txt", FileMode.OpenOrCreate);
                StreamReader reader = new StreamReader(file);
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    count += s.Length;
                }
                file.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                log.Error("FileHandling Exception can handle :" + e);
            }
            return count;
        }
        //public static void test()
        public async static void test()
        {
            //int i=test1();
            Console.WriteLine("Please Wait ....");
            int i = await Task.Run(() => test1());
            Thread.Sleep(5000);
            Console.WriteLine("Number Of Char :" + i);
            log.Info("Number Of Char :" + i);
        }
        public static void test0()
        {
            //while (true)
            //{
            //    test();
            //    //string s = Console.ReadLine();
            //    Thread.Sleep(5000);
            //    Console.WriteLine();
            //}
        }
        
        static void tests()
        {
            while (true)
            {
                Test();
                Thread.Sleep(2000);
                Console.WriteLine("Please Wait ....");
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }

        static async void Test()
        {
            int t = await Task.Run(() => Test1());
            Console.WriteLine("Compute: " + t);
            log.Info("Compute: " + t);
        }

        static int Test1()
        {
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 100000; i++)
                {
                    string value = i.ToString();
                    if (value == null)
                    {
                        return 0;
                    }
                    size += value.Length;
                }
            }
            return size;
        }
        static void Main(string[] args)
        {
            test0();
            tests();
            Console.ReadKey();
        }
    }
}