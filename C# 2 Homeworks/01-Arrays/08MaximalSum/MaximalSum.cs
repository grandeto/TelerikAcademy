﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int currentSum = 0;
            int tmpStart = 0;
            int end = length;
            int start = 0;

            for (int j = 0; j != length; ++j)
            {
                currentSum += arr[j];
                end = j;

                // if the sum is equal, choose the one with more elements
                if (currentSum > maxSum || (currentSum == maxSum && (end - start) < (j - tmpStart)))
                {
                    maxSum = currentSum;
                    start = tmpStart;
                    end = j;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                    tmpStart = j + 1;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
