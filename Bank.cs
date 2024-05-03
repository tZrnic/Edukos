using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class Bank
    {
        private List<Transaction> transactions;
        private List<User> users;

        public Bank()
        {
            transactions = new List<Transaction>();
            users = new List<User>();
        }

        public void NewUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(string userId)
        {
            User userForRemoval = users.FirstOrDefault(u => u.UserId == userId);

            if (userForRemoval == null)
            {
                Console.WriteLine($"Can not find user with userId: {userId}");
            }
            else
            {
                users.Remove(userForRemoval);
            }
        }
        public User GetUserByUserId(string userId)
        {
            User user = users.FirstOrDefault(u => u.UserId == userId);

            if (user == null)
            {
                Console.WriteLine($"Can not find user with userId: {userId}");
                return new User();
            }
            else
            {
                return user;
            }
        }
        public void ChangeUserId(string userId, string newUserId)
        {
            User user = users.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
            {
                Console.WriteLine("UserId not found.");
            }
            else
            {
                user.UserId = newUserId;
            }
        }
        public void ExecuteTransaction(Transaction transaction)
        {
            transaction.ExecuteTransaction();
            transactions.Add(transaction);
        }
    }
}
