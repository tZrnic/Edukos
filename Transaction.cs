using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public abstract class Transaction : ITransaction
    {
        public DateTime ExecutionDate { get; set; }
        public decimal Amount { get; set; }
        public abstract void ExecuteTransaction();
    }
}
