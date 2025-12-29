using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.view
{
    public class BankModifyProfileView
    {
        public static void showChangeOptions()
        {
            Console.WriteLine("Modify Bank Profile");
            BankUtil.createHeader("Change profile info list");
            BankUtil.createOrderedList(new string[]{
                "Change password",
                "Change name",
                "Change phone number",
                "Change address",
                "Change email",
                "Exit"
            });
        }

        public static String takeModifyOption()
        {
            BankUtil.showTakeFunctionNumber();
            return Console.ReadLine();
        }

        public static String takeName()
        {
            Console.Write("Which part do you want to update....\n1) Whole name\n2) First name\n3) Last name\n\nSelection:  ");
            string answer = Console.ReadLine();
            string name = "", firstName = "", lastName = "";

            switch(answer) {

                case "1":
                    Console.WriteLine("Enter a new name: ");
                    name = Console.ReadLine();
                    while(!wholeNameCheck(name))
                    {
                        Console.WriteLine("Please enter a correct first name, letters only, a space, followed by a correct last name, letters only: ");
                        name = Console.ReadLine();
                    }
                    return name;
                case "2":
                    Console.WriteLine("Enter a new first name: ");
                    firstName = Console.ReadLine();
                    while(!firstNameCheck(firstName))
                    {
                        Console.WriteLine("Please enter a correct first name, capital letter first, letters only: ");
                        firstName = Console.ReadLine();
                    }
                    return firstName;
                case "3":
                    Console.WriteLine("Enter a new last name: ");
                    lastName = Console.ReadLine();
                    while (!lastNameCheck(lastName))
                    {
                        Console.WriteLine("Please enter a correct first name, capital letter first, letters only: ");
                        lastName = Console.ReadLine();
                    }
                    return lastName;
            }

            return null;
        }

        public static bool wholeNameCheck(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            int spaceCount = input.Count(c => c == ' ');
            if(spaceCount != 1)
                return false;

            int spaceIndex = input.IndexOf(' ');
            if(spaceIndex == 0 || spaceIndex == input.Length - 1)
                return false;

            string firstName = input.Substring(0, spaceIndex);
            string lastName = input.Substring(spaceIndex + 1);

            if(!Regex.IsMatch(firstName, "^[a-zA-Z]+$"))
                return false;
            if(!Regex.IsMatch(lastName, "^[a-zA-Z]+$"))
                return false;

            return true;
        }

        public static bool firstNameCheck(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (!Regex.IsMatch(input, "^[A-Z][a-z]+(-[A-Z][a-z]+)?$"))
                return false;

            return true;
        }

        public static bool lastNameCheck(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (!Regex.IsMatch(input, "^[A-Z]-?[A-Z][a-z]+$"))
                return false;

            return true;
        }

        public static String takePassword()
        {
            Console.WriteLine("Enter a new password: ");
            return Console.ReadLine();
        }

        public static String takePhoneNumber()
        {
            Console.WriteLine("Enter a new phone number: ");
            return Console.ReadLine();
        }

        public static String takeAddress()
        {
            Console.WriteLine("Enter a new address: ");
            return Console.ReadLine();
        }

        public static String takeEmail()
        {
            Console.WriteLine("Enter a new email address: ");
            return Console.ReadLine();
        }
    }
}
