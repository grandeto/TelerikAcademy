using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            decimal W = decimal.Parse(Console.ReadLine());
            decimal gravitationDiff = 0.17M;
            decimal moonW = W * gravitationDiff;
            string result = string.Format("{0:0.000}", moonW);

            Console.WriteLine(result);
        }
    }
}
