using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class Program
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year) == true)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
