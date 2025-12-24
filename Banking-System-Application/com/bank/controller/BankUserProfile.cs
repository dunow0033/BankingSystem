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

        public static void Run(User user)
        {
            bool stay = true;

            while (stay)
            {

                BankUserProfileView.showWelcome(user);

                string choice = BankUserProfileView.takeChoice();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Modify Bank Profile");
                        Thread.Sleep(1000);
                        BankModifyProfile.Run(user);
                        break;
                    case "2":
                        Console.WriteLine("View Bank Accounts");
                        Thread.Sleep(1000);
                        BankViewAccounts.Run(user);
                        break;
                    case "3":
                        Console.WriteLine("Bank Open Account");
                        Thread.Sleep(1000);
                        BankOpenAccount.Run(user);
                        break;
                    case "4":
                        Console.WriteLine("Bank Logs");
                        //BankLogs.Run(user);
                        break;
                    case "5":
                        Console.WriteLine("Logout");
                        //logout(user);
                        break;
                    default:
                        Console.WriteLine("Error");
                        //Error();
                        break;
                }
            }
        }

        //private static int takeProfileFunctionsChoice(User user) {
        //    string choice;
        //    do
        //    {
        //        choice = BankUserProfileView.takeChoice();
        //    } while (!Regex.IsMatch(choice, "^[1-5]$"));
        //    runProfileFunction(user, int.Parse(choice));
        //    return int.Parse(choice);
        //}

        //private static void runProfileFunction(User user, int choice) 
        //{
        //    switch(choice)
        //    {
        //        case 1: BankModifyProfile.Run(user);
        //                break;
        //        case 2: Console.WriteLine("View Bank Accounts");
        //                //BankViewAccounts.Run(user);
        //                break;
        //        case 3: Console.WriteLine("Bank Open Account");
        //                //BankOpenAccount.Run(user);
        //                break;
        //        case 4: Console.WriteLine("Bank Logs");
        //                //BankLogs.Run(user);
        //                break;
        //        //case 5: logout(user);
        //                //break;
        //        default: Console.WriteLine("Error");
        //                //Error();
        //                break;
        //    }
        //}

        //private static void logout(User user)
        //{ 
        //    BankUserProfileModel.insertLogoutLog(user.Username);
        //}
    }
}
