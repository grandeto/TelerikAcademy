using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Bank_Account_Data
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string middleName = "Malkovic";
            string lastName = "Doe";
            decimal balance = 1000000.4544M;
            string bankName = "UnicreditBulbank";
            string iban = "BG34982394824";
            ulong cardOneNumber = 1111111111111111UL;
            ulong cardTwoNumber = 2222222222222222UL;
            ulong cartThreeNumber = 3333333333333333UL;

            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(lastName);
            Console.WriteLine(balance);
            Console.WriteLine(bankName);
            Console.WriteLine(iban);
            Console.WriteLine(cardOneNumber);
            Console.WriteLine(cardTwoNumber);
            Console.WriteLine(cartThreeNumber);
        }
    }
}
