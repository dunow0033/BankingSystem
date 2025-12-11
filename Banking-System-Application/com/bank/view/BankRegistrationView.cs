using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankRegistrationView
    {
        public static String takeUsername()
        {
            Console.WriteLine("Enter your username(at most 50 characters): ");
            return Console.ReadLine();
        }

        public static String takePassword()
        {
            Console.WriteLine("Enter your password(at most 50 characters): ");
            return Console.ReadLine();
        }

        public static String takeFirstName()
        {
            Console.WriteLine("Enter your first name(at most 50 characters): ");
            return Console.ReadLine();
        }

        public static String takeLastName()
        {
            Console.WriteLine("Enter your last name(at most 50 characters): ");
            return Console.ReadLine();
        }

        public static String takePhoneNumber()
        {
            Console.WriteLine("Enter your phoneNumber: ");
            return Console.ReadLine();
        }

        public static String takeAddress()
        {
            Console.WriteLine("Enter your address(at most 50 characters): ");
            return Console.ReadLine();
        }

        public static String takeEmail()
        {
            Console.WriteLine("Enter your email: ");
            return Console.ReadLine();
        }

        public static void showWrongUsername()
        {
            BankUtil.createMessage("This username already exist or isn't in the correct format!");
        }

        public static void showUnUniqueEmail()
        {
            BankUtil.createMessage("This email is used before!");
        }
    }
}
