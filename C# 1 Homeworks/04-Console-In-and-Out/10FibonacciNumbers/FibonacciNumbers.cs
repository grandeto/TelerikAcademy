using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());
            ulong f1 = 0;
            ulong f2 = 1;
            string final = ", ";

            if (N == 1)
            {
                Console.WriteLine(0);
            }
            else if (N == 0)
            {
                Console.WriteLine(0);
            }
            else if (N == 2)
            {
                Console.WriteLine(1);
            }
            else if (N > 2)
            {
                Console.Write("0, 1");

                for (ulong i = 1; i <= N - 2; i++)
                {

                    ulong sum = f1 + f2;
                    f1 = f2;
                    f2 = sum;
                    final = ", " + sum;
                    Console.Write(final);

                }
            }

        }
    }
}
