using Solid_Principles.Refactored;

BankAccount ahmedAccount = new(12345);

ahmedAccount.Deposit(500);
ahmedAccount.Withdraw(600);
ahmedAccount.Withdraw(200);
BankAccount mohammedAccount = new(12346);

mohammedAccount.Deposit(5000);
mohammedAccount.Withdraw(200);

StatementPrinter.PrintStatement(ahmedAccount);
StatementPrinter.PrintStatement(mohammedAccount);