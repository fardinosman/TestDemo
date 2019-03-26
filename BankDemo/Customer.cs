using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
   public class Customer
    {
        List<Account> _accounts;

        public string Name { get; set; }
        public int SocialSecurityNumber { get; private set; }
        public string Address { get; set; }
        public Customer(string name, int socialsecurityNumber,string address)
        {
            _accounts = new List<Account>();
            this.Name = name;
            this.SocialSecurityNumber = socialsecurityNumber;
            this.Address = Address;
        }

        internal void CreateAccount(Account newAccount)
        {
            _accounts.Add(newAccount); 
        }

        internal string CreateAccountSummery()
        {
            string reportData = "\n\nName: " + Name + "\n";
            reportData += "Address " + Address + "\n\n";
            foreach (Account a in _accounts)
            {
                reportData += a.AccountSummery() + "\n";
            }
            return reportData; 
        }
    }
}
