using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113rdBit
{
    class _3rdBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int p = 3;

            int mask = 1 << p;
            int compare = number & mask;
            int result = compare >> p;

            Console.WriteLine(result);
        }

    }
}
