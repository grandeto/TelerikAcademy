using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            ulong v = ulong.Parse(Console.ReadLine());


            if (v == 0)
            {
                ulong mask = ~((ulong)1 << P);
                ulong final = N & mask;

                Console.WriteLine(final);
            }
            if (v == 1)
            {
                ulong mask = v << P;
                ulong result = N | mask;

                Console.WriteLine(result);
            }
        }
    }
}
