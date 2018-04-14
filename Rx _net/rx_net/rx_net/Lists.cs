using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rx_net
{
    class Lists
    {
        static void Main(string[] args)
        {
            IEnumerable<int> e = new List<int> { 1, 2, 3, 4, 5 };

            IObservable<int> source = e.ToObservable();
            IDisposable subscription = source.Subscribe(
                                        x => Console.WriteLine("OnNext: {0}", x),
                                        ex => Console.WriteLine("OnError: {0}", ex.Message),
                                        () => Console.WriteLine("OnCompleted"));
            Console.ReadKey();
        }
    }
}
