using System;

namespace _15CalcGCD
{
    class calcGCD
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            int a = Math.Abs(int.Parse(nums[0]));
            int b = Math.Abs(int.Parse(nums[1]));
            int bigger = 0;

            bigger = Math.Max(a, b);

            for (int i = bigger; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
