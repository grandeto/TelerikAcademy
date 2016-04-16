using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string number = Console.ReadLine();

            switch(text)
            {
                case "integer":
                    int integer = int.Parse(number);
                    integer += 1;
                    Console.WriteLine(integer);
                    break;
                case "real":
                    double real = double.Parse(number);
                    real += 1;
                    Console.WriteLine("{0:F2}", real);
                    break;
                default:
                    Console.WriteLine(number + "*");
                    break;
            }
        }
    }
}
