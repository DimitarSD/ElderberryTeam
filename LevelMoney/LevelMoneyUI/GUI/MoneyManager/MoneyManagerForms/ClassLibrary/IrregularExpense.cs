namespace TeamElderberryProject
{
    public class IrregularExpense : Expense
    {
        public IrregularExpense(TransactionData data, string description)
            : base(data, description, TransactionType.IrregularExpense)
        {
        }
    }
}