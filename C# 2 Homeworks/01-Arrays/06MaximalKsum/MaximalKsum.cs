using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaximalKsum
{
    class MaximalKsum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            int maxSum = 0;
            int max = 0;
           

            for (int i = 0; i < N; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < K; i++)
            {
                max = intList.Max();
                maxSum += max;
                intList.Remove(max);
                
            }

            Console.WriteLine(maxSum);
        }
    }
}
