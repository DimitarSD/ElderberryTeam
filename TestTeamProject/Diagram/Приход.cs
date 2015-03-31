using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagram
{
    public class Приход : Транзакции
    {
        public void AddMoney(decimal amount)
        {
            Акаунт.CurrentAmount += amount;
        }
    }
}
