using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if ((A > B && A > C && B > C) || (A > B && A > C && B == C))
            {
                Console.WriteLine("{0} {1} {2}", A, B, C);
            }
            else if (A > B && A > C && C > B)
            {
                Console.WriteLine("{0} {1} {2}", A, C, B);
            }
            else if ((B > A && B > C && A > C) || (B > A && B > C && A == C))
            {
                Console.WriteLine("{0} {1} {2}", B, A, C);
            }
            else if (B > A && B > C && C > A)
            {
                Console.WriteLine("{0} {1} {2}", B, C, A);
            }
            else if ((C > A && C > B && A > B) || (C > A && C > B && A == B))
            {
                Console.WriteLine("{0} {1} {2}", C, A, B);
            }
            else if (C > A && C > B && B > A)
            {
                Console.WriteLine("{0} {1} {2}", C, B, A);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", C, B, A);
            }
        }
    }
}
