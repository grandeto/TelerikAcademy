using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Isosceles_Triangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            char copyright = '\u00A9';
            string oneEmptyString = " ";
            string twoEmptyStrings = "  ";
            string threeEmptyStrings = "   ";


            Console.WriteLine(threeEmptyStrings + copyright);
            Console.WriteLine(twoEmptyStrings + copyright + oneEmptyString + copyright);
            Console.WriteLine(oneEmptyString + copyright + threeEmptyStrings + copyright);
            Console.WriteLine(copyright + oneEmptyString + copyright + oneEmptyString + copyright + oneEmptyString + copyright);

        }
    }
}
