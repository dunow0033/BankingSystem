using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankViewAccountsView
    {
        public static String takeChoice()
        {
            Console.WriteLine("Enter choice from the list: ");
            return Console.ReadLine();
        }

        public static String takeAccountNumber()
        {
            Console.WriteLine("Enter bank account number from the list to do this function on: ");
            return Console.ReadLine();
        }

        public static void showEmptyAccounts()
        {
            BankUtil.createMessage("You don't have any account yet!");
        }

        public static void showInactiveAccount()
        {
            BankUtil.createMessage("All your bank accounts are inactive, you cannot do anything here!");
        }

        public static void showUserBankAccountFunctions()
        {
            BankUtil.createHeader("What do you want to do?");
            BankUtil.createOrderedList(new string[]
            {
                "Deposit",
                "Withdraw",
                "Transfer",
                "Show transactions",
                "Close bank account",
                "Exit",
            });
        }

        public static void printAccounts(List<UserBankAccount> userBankAccounts)
        {
            BankUtil.createHeader("My Bank Accounts");
            for(int i = 0; i < userBankAccounts.Count; i++)
            {
                BankUtil.createMessage("Account number (" + (i + 1) + ")");
                //BankUtil.createMessage($"Nickname: {userBankAccounts.");
                Console.WriteLine(userBankAccounts[i]);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
