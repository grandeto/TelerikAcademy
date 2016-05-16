using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Maximal_Increasing_Sequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sequence = 1;
            int maxSequence = 0;

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                    }
                }
                else
                {
                    sequence = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
