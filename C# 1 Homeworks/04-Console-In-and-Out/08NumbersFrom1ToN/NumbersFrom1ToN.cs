using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
