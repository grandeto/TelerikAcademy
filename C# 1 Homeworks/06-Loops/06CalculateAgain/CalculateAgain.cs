using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = n; i > k; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
