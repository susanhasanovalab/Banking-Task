using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Account

    {
        private string ownerName;
        private double balance;

        public readonly string AccountNumber;

        private static int AccountCounter = 1000;

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance mənfi ola bilməz!");
                }
            }
        }

        public Account(string ownerName, double balance)
        {
            OwnerName = ownerName;
            Balance = balance;

            AccountCounter++;
            AccountNumber = "ACC" + AccountCounter;

            Bank.TotalAccounts++;
        }
public void Deposit(double amount)
{
    if (amount > 0)
    {
        Balance += amount;
        Console.WriteLine($"{amount} AZN əlavə edildi.");
    }
    else
    {
        Console.WriteLine("Mənfi məbləğ əlavə etmək olmaz.");
    }
}
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} AZN çıxarıldı.");
            }
            else
            {
                Console.WriteLine("Balans kifayət etmir.");
            }
        }
    }
}
