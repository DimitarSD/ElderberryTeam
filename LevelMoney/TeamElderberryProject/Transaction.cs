using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject
{
    public abstract class Transaction : ITransaction
    {
        static readonly Random random = new Random();// to generate ID

        public string Name { get; protected set; }
        public string TransactionID { get; private set; }
        private const int IdLength = 10;
        private const string IdChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "123456789";
        public decimal Amount { get; private set; }
        public TransactionType TransactionType { get; private set; } // type: income or expense
        private static List<string> allTransactionIDs = new List<string>();//to keep all IDs

        protected Transaction(string name, TransactionType transactionType)
        {
            this.Name = name;
            this.TransactionType = transactionType;
            this.TransactionID = Transaction.GenerateTransactionID();
        }

        private static string GenerateTransactionID()
        {
            StringBuilder idBuilder = new StringBuilder();
            string result;

            do
            {
                for (int i = 0; i < Transaction.IdLength; i++)
                {
                    idBuilder.Append(IdChars[random.Next(0, Transaction.IdChars.Length)]);
                }

                result = idBuilder.ToString();
            }
            while (allTransactionIDs.Contains(result));

            return result;
        }

        public override int GetHashCode()
        {
            return this.TransactionID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.TransactionID.Equals((obj as Transaction).TransactionID);
        }
    }
}
