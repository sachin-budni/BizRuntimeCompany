using System;
using System.Reactive.Subjects;

namespace rx_net
{
    class AsyncSubjects
    {
        static void Main(string[] args)
        {
            asyncSubject();
            Console.WriteLine("----------------------------");
            asyncSubject1();
            Console.WriteLine("----------------------------");
            Console.ReadKey();
        }
        public static void asyncSubject()
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            subject.OnNext("b");
            WriteSequenceToConsole(subject);
            subject.OnNext("c");
        }
        public static void asyncSubject1()
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
        }
        private static void WriteSequenceToConsole(AsyncSubject<string> subject)
        {
            subject.Subscribe(Console.WriteLine);
        }
    }
}
