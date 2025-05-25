using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_TEST
{

    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Deposit amount must be positive.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal amount.");
        }

        public decimal GetBalance()
        {
            return balance;
        }

        class Program
        {
            static void Main(string[] args)
            {
                var account = new BankAccount();
                account.Deposit(3000);
                account.Withdraw(500);
                Console.WriteLine($"Current Balance: {account.GetBalance()}");
            }
        }
    }

}

