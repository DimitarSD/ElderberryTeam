namespace TeamElderberryProject
{
    using TeamElderberryProject.Interfaces;

    public abstract class Expense: Transaction, IExpense
    {
        public Expense(string name, TransactionType transactionType)
            : base(name, TransactionType.Expense)
        {

        }
    }
}
