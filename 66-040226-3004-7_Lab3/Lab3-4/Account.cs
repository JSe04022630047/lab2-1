using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4
{
    class Account
    {
        public string Name { get; set; } // Auto-implemented property
        private decimal balance; // Instance variable

        // Account constructor that receives two parameters  
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance; // Balance's set accessor validates
        }

        // Balance property with validation
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set // Can be used only within the class
            {
                // Validate that the balance is greater than 0.0; if it's not,
                // instance variable balance keeps its prior value
                if (value > 0.0m) // m indicates that 0.0 is a decimal literal
                {
                    balance = value;
                }
            }
        }

        // Method that deposits (adds) only a valid amount to the balance
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m) // If the depositAmount is valid
            {
                Balance = Balance + depositAmount; // Add it to the balance 
            }
        }
    }
}
