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

            User user1 = new User
            {
                FirstName = "John",
                LastName = "Doe",
                AccountNumber = 123456,
                Balance = 1000
            };

            User user2 = new User
            {
                FirstName = "Jane",
                LastName = "Smith",
                AccountNumber = 654321,
                Balance = 2000
            };

            bank.NewUser(customer1);
            bank.NewUser(customer2);

            user1.GetBalance();
            user2.GetBalance();

            TransactionTransfer transfer = new()
            {
                Amount = 500,
                SourceAccountNumber = customer1.AccountNumber,
                DestinationAccountNumber = customer2.AccountNumber
            };

            bank.ExecuteTransaction(transfer);

            user1.GetBalance();
            user2.GetBalance();

            user1.Withdraw(100);
            user2.Withdraw(100);


            TransactionTransfer transaction = new TransactionTransfer();
            transaction.SourceAccountNumber = user1.UserId;
            transaction.DestinationAccountNumber = user2.UserId;

            bank.ExecuteTransaction(transaction);
        }
    }
}