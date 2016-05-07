using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            List<int> frequentList = new List<int>();
            int number = 0;
            int frequent = 1;
            int maxFrequent = 0;

            for (int i = 0; i < N; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < intList.Count-1; i++)
            {
               intList.Sort();
                if (intList[i] == intList[i + 1])
                {
                    frequent++;
                    if (frequent > maxFrequent)
                    {
                        maxFrequent = frequent;
                        number = intList[i];
                    }
                }
                if (intList[i] != intList[i+1])
                {
                    frequent = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", number, maxFrequent);
        }
    }
}
