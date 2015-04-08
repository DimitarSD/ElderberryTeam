namespace TeamElderberryProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    using Newtonsoft.Json;

    using TeamElderberryProject.Interfaces;

    public abstract class Transaction : ITransaction
    {
        private const int IdLength = 10;
        private const string IdChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "123456789";
        private const string TransanctionStringFormat = "Type: {0,16} | Date: {1} | Amount: {2,10:0.00} | Description: {3}";

        private static readonly Random random = new Random();

        private static List<string> allTransactionIDs = new List<string>();
        private string description;
        private string transactionID;

        protected Transaction(TransactionData data, string description, TransactionType transactionType)
        {
            this.Data = data;
            this.Description = description;
            this.TransactionType = transactionType;
            this.TransactionID = Transaction.GenerateTransactionID();
        }

        [JsonConverter(typeof(TransactionType))]
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
                this.description = value;
            }
        }

        public string TransactionID
        {
            get
            {
                return this.transactionID;
            }

            set
            {
                if (value.Length != IdLength)
                {
                    throw new InputException(string.Format(GlobalMessages.InvalidStringLength, IdLength), new ArgumentOutOfRangeException());
                }

                this.transactionID = value;
            }
        }

        public override int GetHashCode()
        {
            return this.TransactionID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.TransactionID.Equals((obj as Transaction).TransactionID);
        }

        public override string ToString()
        {
            StringBuilder transactionToString = new StringBuilder();

            transactionToString.Append(string.Format(
                TransanctionStringFormat,
                this.TransactionType,
                this.Data.Date.Date.ToShortDateString(),
                this.Data.Amount,
                this.Description));

            return transactionToString.ToString();
        }

        public abstract decimal BalanceValue();

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
    }
}