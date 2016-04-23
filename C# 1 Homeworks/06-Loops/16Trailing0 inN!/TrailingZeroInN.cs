using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16Trailing0_inN_
{
    class TrailingZeroInN
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }

            string fToString = factorial.ToString();
            int result = 0;

            for (int j = fToString.Length - 1; j > 0; j--)
            {
                
                if (fToString[j] == '0')
                {
                    result++;
                }
                if (result != 0 && fToString[j] != '0')
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}

//the fastest way
//using System;

//class Program
//{
//    public static int countZeros(int n)
//    {

//        int counter = 0;

//        while (n > 0)
//        {
//            n /= 5;
//            counter += n;
//        }
//        return counter;
//    }
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        int zeros = countZeros(n);
//        Console.WriteLine(zeros);

//    }
//}