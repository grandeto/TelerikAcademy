using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint mask = 7;

            uint rightBits = (number >> 3) & mask;
            uint leftBits = (number >> 24) & mask;

            number = number & ~(mask << 3);
            number = number & ~(mask << 24);

            number = (rightBits << 24) | number;
            number = (leftBits << 3) | number;

            Console.WriteLine(number);

        }
    }
}
