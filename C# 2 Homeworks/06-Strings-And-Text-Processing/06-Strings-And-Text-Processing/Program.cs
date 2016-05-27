using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings_And_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                reversedString.Insert(0, input[i]);
            }

            Console.WriteLine(reversedString.ToString());
        }
    }
}
