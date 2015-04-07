namespace TeamElderberryProject
{
    public class RegularExpense : Expense
    {
        public RegularExpense(TransactionData data, string description)
            : base(data, description, TransactionType.RegularExpense)
        {
        }
    }
}