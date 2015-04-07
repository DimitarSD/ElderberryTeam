namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;

    public abstract class Expense : Transaction, IExpense
    {
        protected Expense(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, transactionType)
        {

        }

        public override decimal BalanceValue()
        {
            return this.Data.Amount * -1;
        }
    }
}