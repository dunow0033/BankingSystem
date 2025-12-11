using Banking_System_Application.com.bank.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankLogin
    {
        private BankLogin()
        { }

        public static void Run()
        {
            String[] credentials = BankLoginView.displayLoginWindow();
            String username = credentials[0];
            String password = credentials[1];
            //checkLogin(username, password);
        }

        //private static void checkLogin(String username, String password)
        //{
        //    String resultPassword = BankLoginModel.getPasswordOf(username);
        //    if(resultPassword == null || !resultPassword.Equals(password))
        //    {
        //        BankLoginView.showWrongPassword();
        //    } else
        //    {
        //        //User user = Bank
        //        BankUserProfile.Run(user);
        //    }
        //}

    }
}
