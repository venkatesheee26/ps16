using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Dhana Lakshmi");

            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Account Holder Name: {account.AccountHolderName}");
            Console.WriteLine($"Balance: {account.GetBalance()}");

            Console.WriteLine();

            account.Deposit(3000);
            Console.WriteLine("After depositing $2000:");
            Console.WriteLine($"Balance: {account.GetBalance()}");

            Console.WriteLine();

            account.Withdraw(500);
            Console.WriteLine("After withdrawing $100:");
            Console.WriteLine($"Balance: {account.GetBalance()}");

            Console.WriteLine();

            account.Withdraw(1000);
            Console.WriteLine("After withdrawing $2000:");
            Console.WriteLine($"Balance: {account.GetBalance()}");
        }
    }
}



