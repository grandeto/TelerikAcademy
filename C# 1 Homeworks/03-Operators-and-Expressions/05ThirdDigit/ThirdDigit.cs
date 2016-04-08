using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int result = (int)Math.Abs(numberN / 100) % 10;

            if(result == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", result);
            }
        }
    }
}
