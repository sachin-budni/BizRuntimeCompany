using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rx_net
{
    class Time
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Time: " + DateTime.Now);

            var source = Observable.Timer(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1))
                                   .Timestamp();
            using (source.Subscribe(x => Console.WriteLine("{0}: {1}", x.Value, x.Timestamp)))
            {
                Console.WriteLine("Press any key to unsubscribe");
                Console.ReadKey();
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
