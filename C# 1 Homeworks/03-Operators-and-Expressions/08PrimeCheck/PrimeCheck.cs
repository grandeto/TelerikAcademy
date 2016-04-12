using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number > 100)
            {
                number = 100;
            }
            if (number <= 1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(Convert.ToString(isPrime).ToLower());
        }
    }
}
