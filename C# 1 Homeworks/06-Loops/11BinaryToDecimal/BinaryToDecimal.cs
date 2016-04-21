using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int pow = int.Parse(binary[i].ToString());
                if (pow == 0)
                {
                    continue;
                }
                else
                {
                    result += (int)Math.Pow(2, (binary.Length - i) - 1);
                }
            }

            Console.WriteLine(result);
        }
    }
}
