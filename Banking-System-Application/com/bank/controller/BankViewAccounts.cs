using Banking_System_Application.com.bank.model;
using Banking_System_Application.com.bank.view;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankViewAccounts
    {
        public BankViewAccounts() 
        { }

        public static void Run(User user)
        {
            Console.Clear();
            Console.WriteLine("View Bank Accounts");
            Thread.Sleep(1000);
            //BankViewAccountModel.
            int functionNumber, userBankAccountNumber;
            List<UserBankAccount> userBankAccounts = showUserBankAccounts(user);
            Console.Clear();
            bool hasActiveAccounts = false;

            if (userBankAccounts.IsNullOrEmpty())
            {
                BankViewAccountsView.showEmptyAccounts();
                return;
            }

            foreach(UserBankAccount userBankAccount in userBankAccounts)
            {
                if(userBankAccount.status.Equals(BankAccountStatus.Active))
                {
                    hasActiveAccounts = true;
                }
            }

            if(!hasActiveAccounts)
            {
                //Console.WriteLine("Showing inactive user bank accounts");
                //Thread.Sleep(3000);
                BankViewAccountsView.showInactiveAccount();
                    //BankUtil.createMessage("All your bank accounts are inactive, you cannot do anything here!");
                return;
            }

            do
            {
                BankViewAccountsView.showUserBankAccountFunctions();
                functionNumber = takeUserBankAccountFunction();
                if (functionNumber == 6) break;
                userBankAccountNumber = takeUserBankAccountNumber(userBankAccounts);
                runUserBankAccountFunction(functionNumber, userBankAccounts[userBankAccountNumber - 1]);
            } while (true);
        }

        private static List<UserBankAccount> showUserBankAccounts(User user)
        {


            Console.WriteLine("Showing user bank accounts\n\n");
            List<UserBankAccount> userBankAccounts = BankViewAccountModel.collectUserBankAccounts(user);
            BankViewAccountsView.printAccounts(userBankAccounts);
            return userBankAccounts;
        }

        private static int takeUserBankAccountFunction()
        {
            string choice;
            do
            {
                choice = BankViewAccountsView.takeChoice();
            } while (!Regex.IsMatch(choice, "^[1-6]$"));

            return int.Parse(choice);
        }

        private static int takeUserBankAccountNumber(List<UserBankAccount> userBankAccounts)
        {
            string userBankAccountNumber;

            do
            {
                userBankAccountNumber = BankViewAccountsView.takeAccountNumber();
            } while (!Regex.IsMatch(userBankAccountNumber, "[1-" + userBankAccounts.Count + "]") ||
                !checkBankAccountActive(userBankAccounts[int.Parse(userBankAccountNumber) - 1]));

            return int.Parse(userBankAccountNumber);
        }

        private static bool checkBankAccountActive(UserBankAccount userBankAccount)
        {
            if (userBankAccount.status.Equals(BankAccountStatus.Active))
            {
                return true;
            }
            else
            {
                BankViewAccountsView.showInactiveAccount();
                return false;
            }
        }

        private static void runUserBankAccountFunction(int choice, UserBankAccount userBankAccount)
        {
            switch(choice)
            {
                case 1: BankDeposit.Run(userBankAccount);
                        break;
                case 2: BankWithdrawal.Run(userBankAccount);
                        break;
                case 3: BankTransfer.Run(userBankAccount);
                        break;
                case 4: BankTransactions.Run(userBankAccount);
                        break;
                case 5: BankCloseAccount.Run(userBankAccount);
                        break;
            }
        }
    }
}
