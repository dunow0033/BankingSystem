using Banking_System_Application.com.bank.model;
using Banking_System_Application.com.bank.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankUserProfile
    {
        public BankUserProfile() { }

        protected static void Run(User user)
        {
            BankUserProfileView.showWelcome(user);
            int choice;
            do
            {
                BankUserProfileView.showProfileFunctions();
                choice = takeProfileFunctionsChoice(user);
            } while(!choice.Equals(5))
        }

        private static int takeProfileFunctionsChoice(User user) {
            string choice;
            do
            {
                choice = BankUserProfileView.takeChoice();
            } while (!Regex.IsMatch(choice, "^[1-5]$"));
            runProfileFunction(user, int.Parse(choice));
            return int.Parse(choice);
        }

        private static void runProfileFunction(User user, int choice) 
        {
            switch(choice)
            {
                case 1: BankModifyProfile.Run(user);
                        break;
                case 2: BankViewAccounts.Run(user);
                        break;
                case 3: BankOpenAccount.Run(user);
                        break;
                case 4: BankLogs.Run(user);
                        break;
            }
        }
    }
}
