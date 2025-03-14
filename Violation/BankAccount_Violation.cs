using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Violation
{
    public class BankAccount_Violation(int accountNumber)
    {
        public int AccountNumber { get; set; } = accountNumber;
        public double Balance { get; private set; }
        private readonly List<string> Transactions = [];

        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Not enouph money");
                return;
            }
            Balance -= amount;
            Transactions.Add($"Withdrew ${amount}. " +
                $"New Balance: ${Balance}");
        }

        public void PrintStatement()
        {
            Console.WriteLine($"Statement for Account: {AccountNumber}");
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }

}

