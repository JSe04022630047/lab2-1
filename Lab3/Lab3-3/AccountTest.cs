using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("John Wick");
            Account account2 = new Account("John Ultrakill");

            Console.WriteLine(string.Format("account1 name is: {0}", account1.Name));
            Console.WriteLine(string.Format("account2 name is: {0}", account2.Name));

            Console.ReadLine();
        }
    }
}
