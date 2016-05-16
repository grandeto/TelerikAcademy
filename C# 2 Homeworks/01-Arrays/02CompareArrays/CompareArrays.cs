using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] firstArray = new int[N];
            int[] secondArray = new int[N];
            bool equal = true;

            for (int i = 0; i < N; i++)
            {
                int firstArrContent = int.Parse(Console.ReadLine());
                firstArray[i] = firstArrContent;
            }

            for (int i = 0; i < N; i++)
            {
                int secondArrContent = int.Parse(Console.ReadLine());
                secondArray[i] = secondArrContent;
            }

            for (int i = 0; i < N; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }

            if (equal)
            {
                Console.WriteLine("Equal");

            }
            if (!equal)
            {
                Console.WriteLine("Not equal");

            }

        }
    }
}
