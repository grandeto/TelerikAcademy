using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            List<int> sorded = new List<int>();
            int min = 0;


            for (int i = 0; i < N; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < N; i++)
            {
                min = intList.Min();
                sorded.Add(min);
                Console.WriteLine(sorded[i]);
                intList.Remove(min);

            }
        }
    }
}
