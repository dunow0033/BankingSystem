using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public static class BankUtil
    {
        //private BankUtil()
        //{

        //}

        public static void createMessage(String paragraph)
        {
            int width = 200;
            int part = (width /2) - (paragraph.Length / 2);
            String bothSides = new string('-', part);
            String spaceArea = new string(' ', 3);
            Console.WriteLine(bothSides + spaceArea + paragraph + spaceArea + bothSides);

        }

        public static bool checkEmail(String email)
        {
            if(email.Count() > 255 || Regex.IsMatch(email, "^[\\\\w\\-\\\\.]+@([\\\\w-]+\\\\.)+[\\\\w-]{2,4}$"))
            {
                BankUtil.createMessage("Email isn't in the correct format!");
                return false;
            } else
            {
                return true;
            }
        }

        public static bool checkAddress(String address)
        {
            if (address.Count() > 50)
            {
                createMessage("Address isn't in the correct format!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkPhoneNumber(String phoneNumber)
        {
            //if(phoneNumber.Count() != 10 || !Regex.IsMatch(phoneNumber, "[0-9]{10}"))
            //{
            //    return false;
            //}

            //String[] validPrefixes = { "010", "011", "012", "015" };
            //String prefix = phoneNumber.Substring(0, 3);
            //if(!validPrefixes.ToList().Contains(prefix))
            //{
            //    createMessage("Phone number isn't in the correct format!");
            //    return false;
            //}

            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        public static bool checkName(String name)
        {
            if(name.Count() > 50)
            {
                createMessage("Name isn't in the correct format!");
                return false;
            } else
            {
                return true;
            }
        }

        public static bool checkPassword(String password)
        {
            if(password.Count() > 50)
            {
                createMessage("Password isn't in the correct format!");
                return false;
            } else
            {
                return true;
            }
        }

        public static void createHeader(String paragraph)
        {
            int width = 200;
            int part = (width / 2) - (paragraph.Count() / 2);
            String rightSide = new string('<', part);
            String leftSide = new string('>', part);
            String spaceArea = new string(' ', 3);
            Console.WriteLine(rightSide + spaceArea + paragraph + spaceArea + leftSide);
        }

        public static void createOrderedList(String[] list)
        {
            for (int i = 0; i < list.Length; ++i)
            {
                Console.WriteLine((i + 1) + "- " + list[i]);
            }
        }

        public static void showTakeFunctionNumber()
        {
            Console.WriteLine("Enter function number from the list: ");
        }

        public static string ConnectionString = @"Server=.;Integrated Security=true;Database=BankingSystem;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
