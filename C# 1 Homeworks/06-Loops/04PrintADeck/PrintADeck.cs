using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            var card = Console.ReadLine();
            int intCard = 0;
            
            if ( card != "J" && card != "Q" && card != "K" && card != "A")
            {
               intCard = int.Parse(card);
            }
            else
            {
                switch (card)
                {
                    case "J":
                        intCard = 11;
                        break;
                    case "Q":
                        intCard = 12;
                        break;
                    case "K":
                        intCard = 13;
                        break;
                    case "A":
                        intCard = 14;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 2; i <= intCard; i++)
            {
                switch (i)
                {
                    case 2:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 3:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 4:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 5:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 6:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 7:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 8:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 9:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 10:
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    case 11:
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        break;
                    case 12:
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        break;
                    case 13:
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                        break;
                    case 14:
                        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
