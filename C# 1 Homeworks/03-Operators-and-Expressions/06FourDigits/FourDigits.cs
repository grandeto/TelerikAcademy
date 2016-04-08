using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int abcd = int.Parse(Console.ReadLine());
            abcd = Math.Abs(abcd);

                if(abcd > 9999)
                {
                    abcd = abcd % 10000;
                }
                if((abcd == 0) || ((abcd / 1000) == 0))
                {
                    abcd = abcd + 1000;
                }

            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd / 10) % 10;
            int d = abcd % 10;

            Console.WriteLine(+ a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
