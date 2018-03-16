using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
    class A
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(MultiThreading));
        /// <summary>
        /// i created sleeps method 
        /// if i want sleep the method for certain time
        /// </summary>
        public void sleeps()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            int time = 5000;
            Thread.Sleep(time);
            log.Info("used sleep method"+time);
        }
        /// <summary>
        /// i created one joins method 
        /// if u join one thread to anothre thread
        /// </summary>
        public void joins()
        {
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            log.Info("used sleep join");

        }
    }
    /// <summary>
    /// its multithreading class 
    /// executing multi thread 
    /// </summary>
    class MultiThreading
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(MultiThreading));
        /// <summary>
        /// its main method executing all the thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            A a1 = new A();
            Thread t1 = new Thread(new ThreadStart(a1.sleeps));
            Thread t2 = new Thread(new ThreadStart(a1.joins));
            t1.Start();
            t2.Start();
            Console.WriteLine();
            try
            {
                t2.Join();
            }
            catch(ThreadStartException e)
            {
                log.Error("its in join method" + e);
            }
            Console.ReadKey();
        }
    }
}
