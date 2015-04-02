using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamElderberryProject.Interfaces
{
    public class RegularIncome : Income
    {
        public RegularIncome(string name, TransactionType transactionType)
            : base(name, TransactionType.Income)
        {

        }
    }
}
