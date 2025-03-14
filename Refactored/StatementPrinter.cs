using System.Transactions;

namespace Solid_Principles.Refactored
{
    public class StatementPrinter {
        public static void PrintStatement(BankAccount account)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Account Statement for Account Number: {account.AccountNumber}");
            Console.WriteLine("=======================================");

            if (account.Transactions.Count == 0)
            {
                Console.WriteLine("No transactions available.");
            }
            else
            {
                foreach (var transaction in account.Transactions)
                {
                    Console.WriteLine($" - {transaction}");
                }
            }

            Console.WriteLine("=======================================");
        }
    }

}
