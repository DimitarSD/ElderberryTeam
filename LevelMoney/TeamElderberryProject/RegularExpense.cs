namespace TeamElderberryProject
{
    public class RegularExpense : Expense
    {
        public RegularExpense(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, TransactionType.Expense)
        {
        }
    }
}