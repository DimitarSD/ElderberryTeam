namespace TeamElderberryProject
{
    public class IrregularIncome : Income
    {
        public IrregularIncome(TransactionData data, string description, TransactionType transactionType)
            : base(data, description, TransactionType.Income)
        {
        }
    }
}