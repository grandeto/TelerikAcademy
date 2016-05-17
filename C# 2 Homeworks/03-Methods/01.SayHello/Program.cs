using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    class Program
    {
        static void Main()
        {
            PrintHello();
        }

        private static void PrintHello()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
