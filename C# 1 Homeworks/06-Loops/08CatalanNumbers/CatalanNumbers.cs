using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger n2 = 1;
            BigInteger n1 = 1;
            BigInteger n = 1;

            //factorial (2n)!
            for (int i = 1; i <= 2 * N; i++)
            {
                n2 *= i;
            }

            //factorial (n + 1)!
            for (int i = 1; i <= N + 1; i++)
            {
                n1 *= i;
            }

            //factorial n!
            for (int i = 1; i <= N; i++)
            {
                n *= i;
            }

            BigInteger result = n2 / (n1 * n);
            Console.WriteLine(result);
        }
    }
}
