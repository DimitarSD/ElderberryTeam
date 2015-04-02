using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject.Interfaces
{
    public abstract class Transaction : ITransaction
    {
        private const int IdLength = 10;
        private const string IdChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "123456789";
        private List<Transaction> transactions;

        static readonly Random random = new Random();// to generate ID

        private string description;
        private string transactionID;
        private decimal amount;
        private DateTime datetime;

        protected Transaction(string description, TransactionType transactionType)
        {
            this.Description = description;
            this.TransactionType = transactionType;
            this.TransactionID = Transaction.GenerateTransactionID();
            this.DateTime = datetime;
            this.transactions = new List<Transaction>();
        }
        public TransactionType TransactionType { get; private set; } // type: income or expense

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
                    //throw new ArgumentNullException("Please provide valid name");
                    throw new InputException("Please provide valid name", new ArgumentNullException());
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    //throw new ArgumentOutOfRangeException("Please provide valid name");
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
                    //throw new ArgumentOutOfRangeException("ID should be exact 10 symbols!");
                    throw new InputException("ID should be exact 10 symbols!", new ArgumentOutOfRangeException());
                }
                this.transactionID = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value < 0)
                {
                    //throw new ArgumentOutOfRangeException("Please provide positive amount");
                    throw new InputException("Please provide positive amount!", new ArgumentOutOfRangeException());
                }

                this.amount = value;
            }
        }

        public DateTime DateTime
        {
            get { return this.datetime; }
            set
            {
               if (value.Date < DateTime.Now)
               {
                   throw new ArgumentException ("We cannot have history date!");
               }
               this.datetime = value.Date;
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



        public virtual void AddTransaction(Transaction transaction)
        {
            this.transactions.Add(transaction);
        }

        public ICollection<Transaction> Transactions
        {
            get { return new List<Transaction>(this.transactions); }
        }
    }
}
