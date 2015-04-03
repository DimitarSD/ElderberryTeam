namespace TeamElderberryProject.Interfaces
{
    using System.Collections.Generic;

    public interface IAccount
    {
        decimal Balance { get; }
        ICollection<ITransaction> Transactions { get; }
    }
}