using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine(B + " " + A);
            }
            else if (A < B)
            {
                Console.WriteLine(A + " " + B);
            }
            else
            {
                Console.WriteLine(A + " " + B);
            }
        }
    }
}
