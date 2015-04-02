using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject.Interfaces
{
    public abstract class Income: Transaction, IIncome
    {

        public Income(string name, TransactionType transactionType)
            : base(name, TransactionType.Income)
        {

        }

        public string IncomeName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
