using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable 1591
#pragma warning disable CS1587
namespace Multithreading
{
    /// <summary>
    /// i used the task parallel class name as Parallels
    /// </summary>
    class Parallels
    {

        /// <summary>
        /// parallel its method .method in side i am executing the for loop
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(TaskParellel));

        public void Parallel()
        {
            log.Info("its executing from inner class to parallel class");
            for(int i=1; i<=10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        } 
    }
    class Tasks
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(TaskParellel));

        public void TaskClass()
        {
            log.Info("its executing from inner class to task class");

            for (int i=1; i<=1; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

        }
    } 
    /// <summary>
    /// its main class of the task parallel
    /// </summary>
    class TaskParellel
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(TaskParellel));
        static void Main(string[] args)
        {
            Parallels p1 = new Parallels();

            
            ///<summary>
            ///using anonymous inner class executing the parallel 
            ///in parallel class one method is there invoke args method we can impliment the array of tasks
            ///method name is parallel
            ///Action we have to use for void purpose
            ///</summary>

            Parallel.Invoke(new Action(p1.Parallel),
                            new Action(p1.Parallel),
                            new Action(p1.Parallel),
                            new Action(p1.Parallel));
            
            ///<example>
            ///using lambda expresion executing the parallel class
            ///by using lambd expresion new create method to explicitly
            /// </example>

            Parallel.Invoke(() =>
            {
                log.Info("i used the lambda in parallel invoke method1");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            },
            () =>
            {
                log.Info("i used the lambda in parallel invoke method2");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            },
            () =>
            {
                log.Info("i used the lambda in parallel invoke method3");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            });

            Console.WriteLine("using Task class");
            
 
            ///<summary>
            ///using task i have implemented three objects 
            /// </summary>

            Tasks task1 = new Tasks();
            Tasks task2 = new Tasks();
            Tasks task3 = new Tasks();

            
 
            ///<example>
            ///i created three programs using Task  class 
            ///i have implement above three objects in Task class Object 
            /// </example>

            Task t1 = new Task(new Action(task1.TaskClass));
            Task t2 = new Task(new Action(task2.TaskClass));
            Task t3 = new Task(new Action(task3.TaskClass));
            t1.Start();
            t2.Start();
            t3.Start();

 
            ///<example>
            ///using lambda expression executing task class examples
            /// </example>
            Task t4=new Task(()=>
            {
                log.Info("using lambda expression execute task parallel class");
                for(int i=1; i<=10; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            });
            ///<example>
            ///using lambda expression executing task class examples
            /// </example>
            Task t5 = new Task(() =>
            {
                log.Info("using lambda expression execute task parallel class");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            });

 
            ///<example>
            ///using lambda expression executing task class examples
            /// </example>
            Task t6 = new Task(() =>
            {
                log.Info("using lambda expression execute task parallel class");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                
            });
            t4.Start();
            t5.Start();
            t6.Start();

            Console.ReadKey();
        }
    }
}
