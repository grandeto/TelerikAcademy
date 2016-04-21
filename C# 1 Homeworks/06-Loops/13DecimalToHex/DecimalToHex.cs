﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexaNumber = String.Empty;

            if (decimalNumber != 0)
            {
                while (decimalNumber > 0)
                {
                    long remainder = decimalNumber % 16;
                    switch (remainder)
                    {
                        case 10:
                            hexaNumber += "A";
                            break;
                        case 11:
                            hexaNumber += "B";
                            break;
                        case 12:
                            hexaNumber += "C";
                            break;
                        case 13:
                            hexaNumber += "D";
                            break;
                        case 14:
                            hexaNumber += "E";
                            break;
                        case 15:
                            hexaNumber += "F";
                            break;
                        default:
                            hexaNumber += remainder.ToString();
                            break;
                    }

                    decimalNumber /= 16;
                }

                for (int i = hexaNumber.Length - 1; i >= 0; i--)
                {
                    string g = Convert.ToString(hexaNumber[i]);
                    Console.Write(g);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
