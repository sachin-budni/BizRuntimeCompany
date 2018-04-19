using System;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;

namespace Ignite_net
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ignition.Start();
            //Console.ReadKey();
            IIgnite ignite = Ignition.Start();
            ICache<int, string> cache = ignite.GetOrCreateCache<int, string>("test");
            cache.Put(1, "Hello");
            cache.Put(2, "World!");
            Console.Write(cache.Get(1)+" ");
            Console.WriteLine(cache.Get(2));
            Console.ReadKey();
        }
    }
}
