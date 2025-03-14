using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Solid_Principles.Refactored
{
    public class BankAccount(int accountNumber)
    {
        public int AccountNumber { get; set; } = accountNumber;
        public double Balance { get; private set; }
        public List<string> Transactions = [];

        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
                return;
            }
            Balance -= amount;
            Transactions.Add($"Withdrew ${amount}. " +
                $"New Balance: ${Balance}");
        }

    }

}
