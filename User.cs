using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class User : Person, IBankAccount
    {
        public decimal Balance { get; set; }
        public string UserId { get; set; }
        public int AccountNumber { get; set; }
        public void GetBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }
        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Not enough money on account. Your balance: {Balance}");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
    }
}
