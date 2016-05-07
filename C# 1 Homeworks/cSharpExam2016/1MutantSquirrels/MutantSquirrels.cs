using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1MutantSquirrels
{
    class MutantSquirrels
    {
        static void Main(string[] args)
        {
            double T = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double S = double.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());

            double sum = T * B * S * N;
            double result = 0;

            if (sum % 2 == 0)
            {
                result = (double)sum * 376439;
            }
            else
            {
                result = (double)sum / 7;
            }

            Console.WriteLine("{0:F3}", result);
        }
    }
}
