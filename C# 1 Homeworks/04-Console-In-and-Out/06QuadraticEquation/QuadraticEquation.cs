using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                if (x1 < x2)
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:F2}", x2);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
            }
            if (delta == 0)
            {
                double root = -b / (2 * a);

                Console.WriteLine("{0:F2}", root);
            }
            if (delta < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
