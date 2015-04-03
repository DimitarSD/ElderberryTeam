namespace TeamElderberryProject.Interfaces
{
    public interface ITransaction
    {
        TransactionData Data { get; }
        string Description { get; set; }
        string TransactionID { get; set; }
        TransactionType TransactionType { get; }
    }
}