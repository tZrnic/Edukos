using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class TransactionTransfer : Transaction
    {
        public int SourceAccountNumber { get; set; }
        public int DestinationAccountNumber { get; set;}

        public override void ExecuteTransaction()
        {
            Console.WriteLine($"Transfer {Amount} from account {SourceAccountNumber} to account {DestinationAccountNumber}");
        }
    }
}
