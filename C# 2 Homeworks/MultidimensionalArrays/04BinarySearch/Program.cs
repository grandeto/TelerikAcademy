using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BinarySearch
{
    class Program
    {
        static void Main()
        {
            //Initializing the array
            Console.Write("Write the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            Console.WriteLine("Write the elements of the array, each on a separate line: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //Initilizing k
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            //Sorting and applying Binary Search method
            Array.Sort(myArray);
            int index = Array.BinarySearch(myArray, k);
            int result = 0;

            if (index < 0)
            {
                index = ~index - 1;
            }
            if (index >= 0)
            {
                result = myArray[index];
            }

            //Printing the result
            Console.WriteLine("The largest number in the array which is <= K is: {0}", result);
        }
    }
}
