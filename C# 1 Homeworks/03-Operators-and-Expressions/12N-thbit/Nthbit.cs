using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12N_thbit
{
    class Nthbit
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            P = Math.Abs(P);
            N = Math.Abs(N);

            if ((P < 0) || (P > Math.Pow(2, 55)))
            {
                P = 6969;
            }
            if (N >= 55)
            {
                N = 54;
            }

            ulong mask = (ulong)1 << N;
            ulong compare = (ulong)P & mask;
            ulong result = compare >> N;

            Console.WriteLine(result);
        }
    }
}