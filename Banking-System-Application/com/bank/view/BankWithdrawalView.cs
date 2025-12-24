using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankWithdrawalView
    {
        public static String takeMoney()
        {
            Console.WriteLine("Enter money to withdraw (-1 to exit): ");
            return Console.ReadLine();
        }

        public static void showWithdrawalEnd()
        {
            BankUtil.createMessage("The number of monthly withdrawals has ended!");
        }
    }
}
