using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Speeds
{
    class Speeds
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] newArray = new int[N];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

        }
    }
}
