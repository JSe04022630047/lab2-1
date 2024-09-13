using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m); // is this possible?

            // Display initial balance of each object
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            // Prompt for then read input
            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount); // add to account1's balance

            // Display balances
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            // Prompt for then read input
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount); // add to account2's balance

            // Display balances
            Console.WriteLine(
               $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            Console.ReadLine();
        }
    }
}
