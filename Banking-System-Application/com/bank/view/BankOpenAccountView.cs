using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankOpenAccountView
    {
        public static String takeNickname()
        {
            Console.WriteLine("Enter the bank account nickname: ");
            return Console.ReadLine();
        }

        public static String takeType()
        {
            Console.WriteLine("Enter the bank type number: ");
            return Console.ReadLine();
        }

        public static String takeCurrency()
        {
            Console.WriteLine("Enter the currency number: ");
            return Console.ReadLine();
        }

        public static String takeInitialBalance()
        {
            Console.WriteLine("Enter the initial balance for this bank account: ");
            return Console.ReadLine();
        }
    }
}
