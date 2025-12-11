using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankApplicationView
    {
        public static void displayMainWindow()
        {
            BankUtil.createHeader("What do you want to do?");
            BankUtil.createOrderedList(new String[]
            {
                "Login", "Register", "Exit"
            });
        }

        public static String takeOption()
        {
            BankUtil.showTakeFunctionNumber();
            return Console.ReadLine();
        }
    }
}
