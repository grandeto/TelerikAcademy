using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SortByStringLength
{
    class Program
    {
        static void Main()
        {
            string[] myArray = { "apple", "strawberry", "banana", "coconut", "lime" };
            string temp = " ";

            //Sorting the array
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i].Length > myArray[j].Length)
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }

            //Printing the array
            Console.WriteLine("The array, sorted by the length of its elements, looks like this: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i != myArray.Length - 1)
                {
                    Console.Write("{0}, ", myArray[i]);
                }
                else
                {
                    Console.WriteLine(myArray[i]);
                }
            }
        }
    }
}
