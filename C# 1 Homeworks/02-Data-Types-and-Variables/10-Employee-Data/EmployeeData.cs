using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Employee_Data
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            byte age = 30;
            char gender = 'm';
            ulong personalNumber = 8306112507UL;
            uint employeeNumber = 27560000U;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(personalNumber);
            Console.WriteLine(employeeNumber);
        }
    }
}
