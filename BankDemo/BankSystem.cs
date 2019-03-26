using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public static class BankSystem
    {
        static Dictionary<int, Customer> _allCustomers = new Dictionary<int, Customer>();
        static Dictionary<int, Account> _allAccount = new Dictionary<int, Account>();

        public static bool CreatenewCustomer(string customerName, int socialSecurityNumber, string address)
        {
            if (!_allCustomers.ContainsKey(socialSecurityNumber))
            {
                _allCustomers.Add(socialSecurityNumber, new Customer("fardin", socialSecurityNumber, address));
                return true; 
            }
            return false;
        }

        internal static bool CreateNewAccount(int ssn, string type, double balance, string date)
        {

            if (_allCustomers.ContainsKey(ssn))
            {

                int newAccountNumber;

                bool ok = false;
                do
                {
                    System.Random rnd = new System.Random();
                    newAccountNumber = rnd.Next(100000, 999999);
                    if (!_allAccount.ContainsKey(newAccountNumber))
                    {
                        ok = true; 
                    }
                } while (ok == false);
                Account newAccount = new Account(type, newAccountNumber, date, balance);
                _allAccount.Add(newAccountNumber, newAccount);

                _allCustomers[ssn].CreateAccount(newAccount);
                return true;
            }
            return false; 
        }

        internal static string PrintAccountSummery(int ssn)
        {
            if (_allCustomers.ContainsKey(ssn))
            {

               return _allCustomers[ssn].CreateAccountSummery();
            }
            return "Error. Customer dosent Exists";
        }
    }
}
