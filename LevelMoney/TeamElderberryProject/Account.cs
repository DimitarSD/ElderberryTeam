namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;
    using System.Collections.Generic;

    public sealed class Account : IAccount
    {
        // Implements Singleton design pattern with lazy loading
        private static readonly Account instance = new Account();
        private ICollection<ITransaction> transactions = new List<ITransaction>();
        private decimal balance;

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
            get 
            {
                this.CalculateBalance();
                return this.balance; 
            }
        }

        public ICollection<ITransaction> Transactions
        {
            get { return this.transactions; }
        }

        public void AddTransaction(ITransaction transaction)
        {
            this.transactions.Add(transaction);            
        }

        private void CalculateBalance()
        {
            foreach (var transaction in this.transactions)
            {
                if (transaction.TransactionType == TransactionType.Income)
                {
                    this.balance += transaction.Data.Amount;
                }
                else
                {
                    this.balance -= transaction.Data.Amount;
                }
            }
        }
    }
}