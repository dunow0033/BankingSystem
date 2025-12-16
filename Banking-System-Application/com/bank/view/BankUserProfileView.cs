using Banking_System_Application.com.bank.controller;
using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankUserProfileView
    {
        public static void showProfileFunctions()
        {
            BankUtil.createHeader("Profile functions");
            BankUtil.createOrderedList(new string[]
            {
                "Change my profile information",
                "View my bank accounts",
                "Open new bank account",
                "View my log",
                "Logout"
            });

            //Console.ReadKey();
        }

        public static void showWelcome(User user)
        {
            Console.Clear();
            BankUtil.createHeader("Welcome, " + user.FirstName + " " + user.LastName);
            showProfileFunctions();
            //string answer = Console.ReadLine();
            string selection; 
            selection = Console.ReadLine().Trim();

            switch (selection)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Change my profile information");
                    BankModifyProfile.Run(user);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("View my bank accounts");
                    //BankViewAccounts.Run(user);
                    break;
                case "3":
                    Console.WriteLine("Open new bank account");
                    //BankOpenAccount.Run(user);
                    break;
                case "4":
                    Console.WriteLine("View my log");
                    break;
                case "5":
                    Console.WriteLine("Log out");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        public static String takeChoice()
        {
            BankUtil.showTakeSelectionNumber();
            return Console.ReadLine();
        }
    }
}
