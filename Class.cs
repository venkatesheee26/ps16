
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_16
{
    internal class BankAccount
    {
        private static int accountCounter = 0;

        public string AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private decimal Balance { get; set; }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = GenerateAccountNumber();
            AccountHolderName = accountHolderName;
            Balance = 9000;
        }
        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        private static string GenerateAccountNumber()
        {
            accountCounter++;
            return $"3689908723451234{accountCounter:3}";
        }
    }
}