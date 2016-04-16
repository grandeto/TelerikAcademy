using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NumbersComparer
{
    class NumbersComparer
    {
        static void Main(string[] args)
        {
            float A = float.Parse(Console.ReadLine());
            float B = float.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine(A);
            }
            if (A < B)
            {
                Console.WriteLine(B);
            }
            if (A == B)
            {
                Console.WriteLine(A);
            }
        }
    }
}
