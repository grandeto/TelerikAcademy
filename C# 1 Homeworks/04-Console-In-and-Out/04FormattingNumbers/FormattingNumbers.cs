using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            string hex = string.Format("{0,-10:X}", a);
            string binary = Convert.ToString(a, 2).PadLeft(10, '0');
            string column3 = string.Format("{0,10:F2}", b);
            string column4 = string.Format("{0,-10:F3}", c);

            Console.WriteLine("{0}|{1}|{2}|{3}|", hex, binary, column3, column4);
        }
    }
}
