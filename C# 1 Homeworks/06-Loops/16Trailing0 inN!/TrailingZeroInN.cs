using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16Trailing0_inN_
{
    class TrailingZeroInN
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 0;

            for (int i = 0; i <= N; i++)
            {
                factorial *= i;
            }

        }
    }
}
