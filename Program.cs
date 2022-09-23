using BankEncapsulation;

BankAccount newPerson = new BankAccount();
newPerson.Deposit(42);
Console.WriteLine(newPerson.getBalance());