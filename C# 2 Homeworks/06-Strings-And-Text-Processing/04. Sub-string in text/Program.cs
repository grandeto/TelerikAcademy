using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            var substring = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();

            // Console.WriteLine(GetSubstringOccurenceCount(text, substring));
            Console.WriteLine(GetSubstringCount(text, substring));
        }

        private static int GetSubstringOccurenceCount(string text, string substring)
        {
            return Regex
                .Matches(text, substring, RegexOptions.IgnoreCase)
                .Count;
        }

        private static int GetSubstringCount(string text, string substring)
        {
            int counter = 0;
            int nextIndex = text.IndexOf(substring);

            while (nextIndex != -1)
            {
                nextIndex = text.IndexOf(substring, nextIndex + 1);
                counter++;
            }

            return counter;
        }
    }
}
