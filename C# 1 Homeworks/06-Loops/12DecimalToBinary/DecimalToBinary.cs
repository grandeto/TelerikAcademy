using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long number = 0;
            string result = "";

            while (input > 0)
            {
                number = input % 2;
                input = input / 2;
                result = number + result;
            }

            Console.WriteLine(result);
        }
    }
}
