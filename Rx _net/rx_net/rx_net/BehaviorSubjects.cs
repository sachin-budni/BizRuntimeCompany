using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rx_net
{
    class BehaviorSubjects
    {
        static void Main(string[] args)
        {
            BehaviorSubjectExample();
            Console.WriteLine("--------------------------------");
            BehaviorSubjectExample2();
            Console.WriteLine("--------------------------------");
            BehaviorSubjectExample3();
            Console.WriteLine("--------------------------------");
            BehaviorSubjectCompletedExample();
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }
        public static void BehaviorSubjectExample()
        {
            //Need to provide a default value.
            var subject = new BehaviorSubject<string>("a");
            subject.Subscribe(Console.WriteLine);
        }

        public static void BehaviorSubjectExample2()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
        }

        public static void BehaviorSubjectExample3()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("c");
            subject.OnNext("d");
            subject.OnNext("e");
        }

        public static void BehaviorSubjectCompletedExample()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            subject.Subscribe(Console.WriteLine);
        }
    }
}
