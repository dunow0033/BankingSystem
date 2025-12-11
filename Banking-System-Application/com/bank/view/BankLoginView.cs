using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankLoginView
    {
        public static String[] displayLoginWindow()
        {
            String[] credentials = new string[2];
            Console.WriteLine("Enter your username: ");
            credentials[0] = Console.ReadLine();
            Console.WriteLine("Enter you password: ");
            credentials[1] = Console.ReadLine();
            return credentials;
        }

        public static void showWrongPassword()
        {
            BankUtil.createMessage("Username or password isn't correct!");
        }
    }
}
