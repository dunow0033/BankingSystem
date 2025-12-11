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
        }

        public static void showWelcome(User user)
        {
            BankUtil.createHeader("Welcome, " + user.FirstName + " " + user.LastName);
        }

        public static String takeChoice()
        {
            BankUtil.showTakeFunctionNumber();
            return Console.ReadLine();
        }
    }
}
