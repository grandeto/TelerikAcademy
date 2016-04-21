using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double factorial = 1;
            double S = 1;

            for (double i = 1; i <= N; i++)
            {
                factorial *= i;
                double test = factorial / Math.Pow(x, i);
                S += test;

            }

            Console.WriteLine("{0:F5}", S);
        }
    }
}
