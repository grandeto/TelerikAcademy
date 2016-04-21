using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            BigInteger numerator = 1;
            BigInteger denominator = 1;

            for (int i = n; i > k; i--)
            {
                numerator *= i;
            }

            for (int i = n - k; i >= 1; i--)
            {
                denominator *= i;
            }

            Console.WriteLine(numerator / denominator);

        }
    }
}
