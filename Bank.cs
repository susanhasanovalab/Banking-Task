using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Bank
  
    {
        public const string BankName = "CodeBank";

        public static int TotalAccounts;

        public static readonly DateTime CreatedDate;

        static Bank()
        {
            CreatedDate = DateTime.Now;
        }

        public static void ShowBankInfo()
        {
            Console.WriteLine($"Bank Name: {BankName}");
            Console.WriteLine($"Total Accounts: {TotalAccounts}");
            Console.WriteLine($"Created Date: {CreatedDate}");
        }
    }
}

