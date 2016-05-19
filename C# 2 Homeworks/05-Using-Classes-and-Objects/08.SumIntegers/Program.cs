using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumIntegers
{
    class Program
    {
        static int CalculateSumOfIntegers(string[] sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += Convert.ToInt32(sequence[i]);
            }

            return sum;
        }

        static void Main()
        {
            string[] sequence = Console.ReadLine().Split(' ');

            Console.WriteLine(CalculateSumOfIntegers(sequence));
        }
    }
}
