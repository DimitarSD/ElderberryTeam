using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject
{
    public class IrregularExpense: Expense
    {
        public IrregularExpense(string name, TransactionType transactionType)
            : base(name, TransactionType.Expense)
        {

        }
    }
}
