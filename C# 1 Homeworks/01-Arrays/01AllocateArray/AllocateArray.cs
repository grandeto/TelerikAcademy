using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int index = 0; index < N; index++)
            {
                array[index] = index;
                int sum = (int)array[index] * 5;
                Console.WriteLine(sum);
            }
        }
    }
}
