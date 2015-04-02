using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamElderberryProject
{
    public interface ITransaction //there is a struct TransactionalData for the same purpose, to be reviewed
    {
        string Name { get; set; }
        string TransactionID { get; set; }
        decimal Amount { get; set; }
        TransactionType TransactionType { get; private set; }
        string ToString();
    }
}
