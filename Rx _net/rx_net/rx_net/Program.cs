using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rx_net
{
    class Program
    {
        static void Main(string[] args)
        {
            //var observable = Observable.Range(2, 7);
            //IObserver<int> observer = Observer.Create<int>(
            //    Console.WriteLine,
            //    (error) => { Console.WriteLine(error.Message); },
            //    () => { Console.WriteLine("Observation Complete"); }
            //    );
            //var subscription = observable.Subscribe(observer);

            //subscription.Dispose();

            //Console.ReadKey();

            IObservable<int> source = Observable.Range(1, 10);
            IObserver<int> obsvr = Observer.Create<int>(
                x => Console.WriteLine("OnNext: {0}", x),
                ex => Console.WriteLine("OnError: {0}", ex.Message),
                () => Console.WriteLine("OnCompleted"));
            IDisposable subscription = source.Subscribe(obsvr);
            Console.WriteLine("Press ENTER to unsubscribe...");
            Console.ReadLine();
            subscription.Dispose();


        }
    }
}
