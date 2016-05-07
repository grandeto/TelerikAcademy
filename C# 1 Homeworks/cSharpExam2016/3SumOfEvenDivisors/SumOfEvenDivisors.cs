using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SumOfEvenDivisors
{
    class SumOfEvenDivisors
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    double buffer = i;
                    double del = buffer / j;
                    if (del % 2 == 0)
                    {
                        result += (int)del;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
