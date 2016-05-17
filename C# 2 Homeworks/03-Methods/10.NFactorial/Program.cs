using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    class Program
    {
        static BigInteger CalculateFactorial(int[] sequence)
        {
            BigInteger result = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                result *= sequence[i];
            }

            return result;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] sequence = new int[number];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = i + 1;
            }

            Console.WriteLine(CalculateFactorial(sequence));
        }
    }
}
