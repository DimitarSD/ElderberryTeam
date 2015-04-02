using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamElderberryProject.Interfaces
{
    public interface ITransaction //there is a struct TransactionalData for the same purpose, to be reviewed
    {
        string Description { get; set; }
        string TransactionID { get; set; }
        decimal Amount { get; set; }
        TransactionType TransactionType { get; }
        DateTime DateTime { get; }
        string ToString();
        void AddTransaction(Transaction transaction);
        ICollection<Transaction> Transactions { get; }
    }
}
