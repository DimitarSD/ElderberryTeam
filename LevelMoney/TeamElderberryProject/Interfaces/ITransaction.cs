namespace TeamElderberryProject.Interfaces
{
    public interface ITransaction
    {
        string Description { get; set; }
        string TransactionID { get; set; }
        TransactionType TransactionType { get; }
    }
}