﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            
            if((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
