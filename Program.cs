using ConsoleApp15;
using System;

class Program
{
    static void Main(string[] args)
    {
        Account acc1 = new Account("CAMILA", 500);
        Account acc2 = new Account("SUSAN", 1000);

        acc1.Deposit(200);
        acc1.Withdraw(100);

        acc2.Withdraw(1500);

        Console.WriteLine();

        Console.WriteLine($"{acc1.OwnerName} - {acc1.AccountNumber} - Balance: {acc1.Balance}");
        Console.WriteLine($"{acc2.OwnerName} - {acc2.AccountNumber} - Balance: {acc2.Balance}");

        Console.WriteLine();

        Bank.ShowBankInfo();

        Console.ReadLine();
    }
}