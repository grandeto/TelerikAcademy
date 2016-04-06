using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine(a + " " + b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a + " " + b);
        }
    }
}
