using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("Deep");
            myAccount.Deposit(100000);
            myAccount.Withdraw(500);
            Console.WriteLine($"Account Number:{myAccount.AccountNumber}");
            Console.WriteLine($"Account Holder:{myAccount.AccountHolderName}");
            Console.WriteLine($"Account Balance:{myAccount.Balance}");
            Console.ReadKey();
        }
    }
}
