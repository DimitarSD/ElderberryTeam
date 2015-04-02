using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject
{
    public class IrregularIncome : Income
    {
        public IrregularIncome(string name, TransactionType transactionType)
            : base(name, TransactionType.Income)
        {

        }
    }
}
