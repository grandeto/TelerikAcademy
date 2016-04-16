using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BiggestОf3
{
    class BiggestОf3
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine(A);
            }
            else if (B > A && B > C)
            {
                Console.WriteLine(B);
            }
            else if (C > A && C > B)
            {
                Console.WriteLine(C);
            }
            else
            {
                Console.WriteLine(A);
            }
        }
    }
}
