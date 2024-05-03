using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public interface IBankAccount
    {
        void GetBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
