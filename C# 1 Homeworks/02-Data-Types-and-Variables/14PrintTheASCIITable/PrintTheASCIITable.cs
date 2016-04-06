using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0x21; i <= 0x7E; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}