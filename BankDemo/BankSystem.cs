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

        internal static int CreateNewAccount(int ssn, string type, double balance, string date)
        {

            if (_allCustomers.ContainsKey(ssn))
            {

                int newAccountNumber = -1;

                bool ok = false;
                do
                {
                    System.Random rnd = new System.Random();
                    newAccountNumber = rnd.Next(100000, 999999);
                    if (_allAccount.ContainsKey(newAccountNumber))
                    {
                        newAccountNumber = -1;
                    }
                } while (newAccountNumber < 0);
                Account newAccount = new Account(type, newAccountNumber, date, balance);
                _allAccount.Add(newAccountNumber, newAccount);

                _allCustomers[ssn].CreateAccount(newAccount);
                return newAccountNumber;
            }
            return -1; 
        }

        internal static string PrintAccountSummery(int ssn)
        {
            if (_allCustomers.ContainsKey(ssn))
            {

               return _allCustomers[ssn].CreateAccountSummery();
            }
            return "Error. Customer dosent Exists";
        }

        internal static bool WithdrawMoney(int accountNumber, double amount)
        {
            if (_allAccount.ContainsKey(accountNumber))
            {

                _allAccount[accountNumber].WithdrawMoney(amount);
                return true;
            }
            return false;
        }
    }
}
