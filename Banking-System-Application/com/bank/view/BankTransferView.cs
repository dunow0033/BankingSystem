using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankTransferView
    {
        public static String takeMoney()
        {
            Console.WriteLine("Enter money to be transferred: ");
            return Console.ReadLine();
        }

        public static string takeOtherAccount()
        {
            Console.WriteLine("Enter the ID of the other user bank account(-1 to exit): ");
            return Console.ReadLine();
        }

        public static void showInvalidAccount()
        {
            BankUtil.createMessage("This bank account ID doesn't exist or isn't active!");
        }

        public static void showSameAccount()
        {
            BankUtil.createMessage("You cannot transfer to the same bank account!");
        }
    }
}
