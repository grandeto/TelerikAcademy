using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? firstVar = null;
            double? secondVar = null;

            Console.WriteLine(firstVar);
            Console.WriteLine(secondVar);

            firstVar = 222;
            secondVar = 222.22;

            Console.WriteLine(firstVar);
            Console.WriteLine(secondVar);
        }
    }
}
