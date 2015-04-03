namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;
    using System.Collections.Generic;

    public sealed class Account : IAccount
    {
        // Implements Singleton design pattern with lazy loading
        private static readonly Account instance = new Account();
        private ICollection<ITransaction> transactions = new List<ITransaction>();

        private Account() { }

        public static Account Instance
        {
            get
            {
                return instance;
            }
        }

        public decimal Balance
        {
            get { throw new System.NotImplementedException(); }
        }

        public ICollection<ITransaction> Transactions
        {
            get { return this.transactions; }
        }

        public void AddTransaction(ITransaction transaction)
        {
            this.transactions.Add(transaction);            
        }
    }
}