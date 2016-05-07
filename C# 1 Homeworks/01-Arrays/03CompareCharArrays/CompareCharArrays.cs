using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string seccond = Console.ReadLine();

            char[] firstArr = first.ToCharArray();
            char[] secondArr = seccond.ToCharArray();

            string result = "=";

            if (firstArr.Length > secondArr.Length)
            {
                result = ">";
            }
            else if (firstArr.Length < secondArr.Length)
            {
                result = "<";
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (first[i] != seccond[i])
                    {
                        result = (first[i] < seccond[i]) ? "<" : ">";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
