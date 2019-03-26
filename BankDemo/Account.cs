using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class Account
    {
        List<AccountEvent> _accountEvent;
        public string  Type { get; private set; }
        public int AccountNumber { get; private set; }
        public Account(string type, int accountNumber, string date, double money)
        {
            _accountEvent = new List<AccountEvent>();
            this.Type = type;
            this.AccountNumber = accountNumber;
            _accountEvent.Add(new AccountEvent(date, money));
        }

        public void AddAcoountEvents(string date, double money)
        {
            _accountEvent.Add(new AccountEvent(date, money)); 
        }
        public double Calculatebalance()
        {
            double balance = 0;
            foreach (AccountEvent ae in _accountEvent)
            {
                balance += ae.Money;
            }
            return balance;
        }
        public bool BeenOverdrawn()
        {
            double balance = 0;
            foreach (AccountEvent  ae in _accountEvent)
            {
                balance += ae.Money;
                if (balance > 0)
                {
                    return true;
                }
            }
            return false;
        }
        

        internal string AccountSummery()
        {
            string reportPart = "Balance: " + Calculatebalance().ToString();
            reportPart += "Overdrawn:  " + BeenOverdrawn().ToString() + "\n\n";
            reportPart += "Events:" + "\n";

            foreach (AccountEvent ae in _accountEvent)
            {
                reportPart += ae.Status() + "\n"; 
            }
            return reportPart;
        }

        internal void WithdrawMoney(double amount)
        {
            _accountEvent.Add(new AccountEvent(System.DateTime.Now.ToString("D"), amount));
        }
    }
}
