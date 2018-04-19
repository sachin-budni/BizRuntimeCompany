using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache;
using System;

namespace Ignite_net
{
    class Persons
    {
        static void Main(string[] args)
        {
            var cfg = new IgniteConfiguration
            {
                BinaryConfiguration = new BinaryConfiguration(typeof(Person))
            };
            IIgnite ignite = Ignition.Start(cfg);
            ICache<int, Person> cache = ignite.GetOrCreateCache<int, Person>("persons");
            cache[1] = new Person { Name = "John Doe", Age = 27 };
            foreach (ICacheEntry<int, Person> cacheEntry in cache)
            Console.WriteLine(cacheEntry);

            var binCache = cache.WithKeepBinary<int, IBinaryObject>();
            IBinaryObject binPerson = binCache[1];
            Console.WriteLine(binPerson.GetField<string>("Name"));

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Person [Name={Name}, Age={Age}]";
        }
    }
    
}
