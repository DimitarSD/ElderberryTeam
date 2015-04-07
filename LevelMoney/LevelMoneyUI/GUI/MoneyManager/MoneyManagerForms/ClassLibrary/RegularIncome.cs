namespace TeamElderberryProject
{
    public class RegularIncome : Income
    {
        public RegularIncome(TransactionData data, string description)
            : base(data, description, TransactionType.RegularIncome)
        {
        }
    }
}