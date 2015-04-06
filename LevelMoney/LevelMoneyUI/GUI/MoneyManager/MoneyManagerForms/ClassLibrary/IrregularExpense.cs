namespace TeamElderberryProject
{
    public class IrregularExpense : Expense
    {
        public IrregularExpense(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, TransactionType.IrregularExpense)
        {
        }
    }
}