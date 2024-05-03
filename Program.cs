using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DZ1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new();

            User customer1 = new User
            {
                FirstName = "John",
                LastName = "Doe",
                AccountNumber = 123456,
                Balance = 1000
            };

            User customer2 = new User
            {
                FirstName = "Jane",
                LastName = "Smith",
                AccountNumber = 654321,
                Balance = 2000
            };

            bank.NewUser(customer1);
            bank.NewUser(customer2);

            customer1.GetBalance();
            customer2.GetBalance();

            TransactionTransfer transfer = new()
            {
                Amount = 500,
                SourceAccountNumber = customer1.AccountNumber,
                DestinationAccountNumber = customer2.AccountNumber
            };

            bank.ExecuteTransaction(transfer);

            customer1.GetBalance();
            customer2.GetBalance();
        }
    }
}