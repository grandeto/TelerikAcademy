using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal area = width * height;
            decimal perimeter = 2 * (width + height);
            string result = string.Format("{0:0.00} {1:0.00}", area, perimeter);

            Console.WriteLine(result);
        }
    }
}
