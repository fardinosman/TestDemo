using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            bool stopProgram = false;

            do
            {
                PrintMenu();
                stopProgram = selectFromMenu();
            } while (stopProgram ==false);
        }

        private static bool selectFromMenu()
        {
            char keyStroke = Console.ReadKey().KeyChar;

            switch (keyStroke)
            {
                case '1':
                    Console.WriteLine("You have selected: Create customer");
                    CreateCustomer();
                    return false;
                case '2':
                    Console.WriteLine("You have selected: Create Account");
                    CreateAccount();
                    return false;
                case '3':
                    Console.WriteLine("You have selected: Withdraw money");
                        
                    return false;
                case '4':
                    Console.WriteLine("You have selected: Deposit Money");
                 
                    return false;
           
                case '5':
                    Console.WriteLine("You have selected: pritn Account summery");
                    PrintAccountSummery();
                    return false;
                case '6':
                    Console.WriteLine("You have selected: pritn Account");

                    return true;
        
            }
            return false;
        }

        private static void PrintAccountSummery()
        {
            Console.WriteLine("Enter new customer social security number:  ");
            int ssn;
            try
            {
                ssn = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                ssn = -1;
            }

            Console.WriteLine(  BankSystem.PrintAccountSummery(ssn));
        }

        private static void CreateAccount()
        {
            Console.WriteLine("Enter new customer social security number:  ");
            int ssn;
            try
            {
                ssn = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                ssn = -1;
            }

            Console.WriteLine("Enter defualt balance:  ");
            double  balance;
            try
            {
                balance = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                balance = -1;
            }

            Console.WriteLine();
            Console.WriteLine("Enter new account type: ");
            string type = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Enter new date: ");
            string date = Console.ReadLine();
            if (type.Length >0 & ssn >0)
            {
                bool succes = BankSystem.CreateNewAccount(ssn, type, balance, date);
            }
            else
            {
                Console.WriteLine("Not all appllyed information was correct");
            }
        }

        private static void CreateCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("Enter new customers name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new customers social security number: ");
            int ssn;
            try
            {
                 ssn = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                ssn = -1;
            }
          
            Console.WriteLine("Enter new customers address: ");
            string adress = Console.ReadLine();

            if (name.Length > 0 & ssn > 0 & adress.Length >0)
            {
                bool success = BankSystem.CreatenewCustomer(name, ssn, adress);
                if (success == true)
                {
                    Console.WriteLine("New customer created");
                }
                else
                {
                    Console.WriteLine("New Customer was not created");
                }
            }
            else
            {
                Console.WriteLine("Not all apllyed information was correct.");
            }
        }

        private static void PrintMenu()
        {
            PrintTopOfMenu("Menue");
            Console.WriteLine("1. Create new customer");
            Console.WriteLine("2. Create new account");
            Console.WriteLine("3. Withdraw money");
            Console.WriteLine("4. Deposit money");
            Console.WriteLine("5. Print Account Summery");
            Console.WriteLine("6. End program" );
        }
        private static void PrintTopOfMenu(string TopName)
        {
            Console.WriteLine( "--- "+ TopName + " --------------");
        }
    }
}
