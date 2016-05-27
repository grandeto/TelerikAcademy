using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_string
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
