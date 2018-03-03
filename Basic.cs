using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_1
{
    class Basic
    {
        static void Main(string[] args)
        {
            int i = 10;
            byte k = 2;
            short l = 30;
            long n = 109990L;
            float m = 20.3F;
            double j = 10.4;
            unsafe
            {
                int* Jk = &i;

                Console.WriteLine(i + k);
                Console.WriteLine(i - k);
                Console.WriteLine(i * k);
                Console.WriteLine(i / k);
                Console.WriteLine();

                Console.WriteLine(j);

                Console.WriteLine(i);
                i++;
                Console.WriteLine(i);
                Console.WriteLine(++i);
                i--;
                Console.WriteLine(i);
                Console.WriteLine(--i);

                Console.WriteLine(k);
                Console.WriteLine(n);
                Console.WriteLine(l);
                Console.WriteLine(m);
                Console.WriteLine();
                Console.WriteLine(*Jk);
                Console.WriteLine((int)Jk);

                Console.WriteLine(i > k ? true : false);
            }
            Console.Read();
        }
    }
}
