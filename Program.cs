using BankEncapsulation;

BankAccount newPerson = new BankAccount();
newPerson.Deposit(42);
newPerson.Withdraw(12);
Console.WriteLine(newPerson.getBalance());