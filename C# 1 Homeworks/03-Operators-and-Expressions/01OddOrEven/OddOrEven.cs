using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 != 0)
            {
                Console.WriteLine("odd {0}", number);
            }
            else
            {
                Console.WriteLine("even {0}", number);
            }
        }
    }
}
