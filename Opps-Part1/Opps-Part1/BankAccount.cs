using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Part1
{
    internal class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = GenerateAccountNumber();
            AccountHolderName = accountHolderName;
            Balance = 0;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. Neww balance:{Balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal faield");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}.New balance:{Balance:C}");
            }
        }
        private static string GenerateAccountNumber()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10);

        }
    }

   
}
