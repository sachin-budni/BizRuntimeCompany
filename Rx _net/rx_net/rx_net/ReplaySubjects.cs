using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rx_net
{
    class ReplaySubjects
    {
        static void Main(string[] args)
        {
            replaySubject();
            Console.WriteLine("--------------------------------");
            replaySubject1();
            Console.WriteLine("--------------------------------");
            replaySubjectTime();
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }
        public static void replaySubject()
        {
            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            subject.OnNext("b");
            WriteSequenceToConsole(subject);
            subject.OnNext("c");
        }
        public static void replaySubject1()
        {
            var bufferSize = 2;
            var subject = new ReplaySubject<string>(bufferSize);
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
        }
        public static void replaySubjectTime()
        {
            var window = TimeSpan.FromMilliseconds(1500);
            var subject = new ReplaySubject<string>(window);
            subject.OnNext("w");
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            subject.OnNext("x");
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            subject.OnNext("y");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("z");
        }
        private static void WriteSequenceToConsole(ReplaySubject<string> subject)
        {
            subject.Subscribe(Console.WriteLine);
        }
    }
}
