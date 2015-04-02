using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject
{
    public abstract class Expense: Transaction, IExpense
    {
        public Expense(string name, TransactionType transactionType)
            : base(name, TransactionType.Expense)
        {

        }
    }
}
