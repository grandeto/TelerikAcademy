using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(65 + i);
            }

            string word = Console.ReadLine().ToUpper();
            int index = -2;

            for (int i = 0; i < word.Length; i++)
            {
                index = Array.IndexOf(arr, word[i]);
                Console.WriteLine(index);
            }
        }
    }
}
