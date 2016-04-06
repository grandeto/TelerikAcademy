using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings_Аnd_Objects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object objVar = hello + " " + world;

            string finalString = (string)objVar;

            Console.WriteLine(finalString);
        }
    }
}
