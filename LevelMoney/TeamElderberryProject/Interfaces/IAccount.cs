namespace TeamElderberryProject.Interfaces
{
    using System.Collections.Generic;

    public interface IAccount
    {
        decimal Balance { get; }

        IList<ITransaction> Transactions { get; }

        void AddTransaction(ITransaction transaction);
    }
}