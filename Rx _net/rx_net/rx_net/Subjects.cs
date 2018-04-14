using System;
using System.Reactive.Subjects;

namespace rx_net
{
    class Subjects
    {
        static void Main(string[] args)
        {
            subject();
            Console.ReadKey();
        }
        public static void subject()
        {
            var subject = new Subject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            //subject.OnCompleted();
            subject.OnNext("d");
        }

        private static void WriteSequenceToConsole(Subject<string> subject)
        {
            subject.Subscribe(Console.WriteLine);
        }
    }
}
