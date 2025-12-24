using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankDepositView
    {
        public static string takeMoney() 
        {
            Console.WriteLine("Enter money to deposit to your bank account (-1 to exit): ");
            return Console.ReadLine();
        }
    }
}
