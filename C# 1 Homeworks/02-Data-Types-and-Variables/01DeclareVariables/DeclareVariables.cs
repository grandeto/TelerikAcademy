using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            byte ninetySeven = 97;
            sbyte oneHundredAndFifteen = -115;
            ushort fiveTwoOneThreeZero = 52130;
            short tenThousend = 10000;
            int fourMilion = 4825932;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", ninetySeven, oneHundredAndFifteen, fiveTwoOneThreeZero, tenThousend, fourMilion);
        }
    }
}
