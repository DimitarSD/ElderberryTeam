namespace TeamElderberryProject.Interfaces
{
    public class RegularIncome : Income
    {
        public RegularIncome(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, TransactionType.Income)
        {
        }
    }
}