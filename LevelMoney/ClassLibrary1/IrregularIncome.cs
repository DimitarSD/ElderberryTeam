namespace TeamElderberryProject
{
    public class IrregularIncome : Income
    {
        public IrregularIncome(TransactionData data, string description)
            : base(data, description, TransactionType.IrregularIncome)
        {
        }
    }
}