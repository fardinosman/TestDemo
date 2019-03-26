
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
   public class AccountEvent
    {
        public double Money { get; private set; }
        public string Date { get; private set; }

        public AccountEvent(string date, double money)
        {
            this.Money = money;
            this.Date = date;
        }

        internal string Status()
        {
            return Date + ": " + Money;
        }

        
    }
}
