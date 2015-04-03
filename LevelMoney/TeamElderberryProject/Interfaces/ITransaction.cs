namespace TeamElderberryProject.Interfaces
{
    using System.Collections.Generic;

    public interface ITransaction
    {
        string Description { get; set; }
        string TransactionID { get; set; }
        TransactionType TransactionType { get; }
    }
}