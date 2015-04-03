namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;

    public abstract class Expense: Transaction, IExpense
    {
        protected Expense(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, TransactionType.Expense)
        {

        }
    }
}