namespace TeamElderberryProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamElderberryProject.Interfaces;

    public abstract class Transaction : ITransaction
    {
        private const int IdLength = 10;
        private const string IdChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "123456789";

        static readonly Random random = new Random();// to generate ID

        private string description;
        private string transactionID;

        protected Transaction(TransactionData data, string description, TransactionType transactionType)
        {
            this.Data = data;
            this.Description = description;
            this.TransactionType = transactionType;
            this.TransactionID = Transaction.GenerateTransactionID();
        }
        public TransactionType TransactionType { get; protected set; }

        public TransactionData Data { get; protected set; }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InputException("Please provide valid name", new ArgumentNullException());
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InputException("Please provide valid name", new ArgumentOutOfRangeException());
                }

                this.description = value;
            }
        }

        public string TransactionID
        {
            get { return this.transactionID; }
            set
            {
                if (value.Length != 10)
                {
                    throw new InputException("ID should be exact 10 symbols!", new ArgumentOutOfRangeException());
                }

                this.transactionID = value;
            }
        }

        private static List<string> allTransactionIDs = new List<string>();//to keep all IDs

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
