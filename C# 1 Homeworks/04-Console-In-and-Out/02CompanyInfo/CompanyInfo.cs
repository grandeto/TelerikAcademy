using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companyWebsite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhone);

            if (companyFax == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", companyFax);
            }

            Console.WriteLine("Web site: {0}", companyWebsite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
