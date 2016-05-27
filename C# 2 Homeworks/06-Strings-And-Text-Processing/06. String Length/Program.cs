using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            text = text.Replace(@"\", string.Empty);
            Console.WriteLine(text.PadRight(20, '*'));
        }
    }
}
