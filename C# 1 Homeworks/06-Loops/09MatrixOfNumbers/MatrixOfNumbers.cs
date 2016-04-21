using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = N;
            int j = 0;

            for (int i = 1; i <= N; i++)
            {
                j += 1;
                for (int g = j; g <= K; g++)
                {
                    Console.Write(g + " ");
                }
                K += 1;
                Console.WriteLine();

                //nested loop - the inteligent way:

                //int n = Int32.Parse(Console.ReadLine());
                //int temp = n;

                //for (int i = 1; i <= n; i++)
                //{
                //    for (int j = i; j < n + i; j++)
                //    {
                //        Console.Write(j);
                //    }

                //    Console.WriteLine();
                }
        }
    }
}
