using Banking_System_Application.com.bank.model;
using Banking_System_Application.com.bank.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankModifyProfile
    {
        public BankModifyProfile() { }

        public static void Run(User user)
        {
            Console.Clear();
            Console.WriteLine("Modify Bank Profile");
            BankModifyProfileView.showChangeOptions();
            takeChangeOption(user);
        }

        private static void takeChangeOption(User user)
        {
            string option;
            do
            {
                option = BankModifyProfileView.takeModifyOption();
            } while (!Regex.IsMatch(option, "^[1-6]$"));
            runChangeOption(user, int.Parse(option));
        }

        private static void runChangeOption(User user, int option)
        {
            switch(option)
            {
                case 1:
                    changePassword(user);
                    break;
                case 2:
                    changeUsername(user);
                    break;
                case 3:
                    changePhoneNumber(user);
                    break;
                case 4:
                    changeAddress(user);
                    break;
                case 5:
                    Console.WriteLine("Change email");
                    Thread.Sleep(3000);
                    changeEmail(user);
                    break;
            }
        }

        private static void changeUsername(User user)
        {
            string Name;

            Console.Clear();
            Console.WriteLine("Change Name\n\n");

            do
            {
                Name = BankModifyProfileView.takeName();
            } while (!BankUtil.checkName(Name));

            BankModifyProfileModel.updateUsername(Name, user.Username);
        }

        private static void changePassword(User user)
        {
            Console.Clear();
            Console.WriteLine("Change Password\n\n");

            string password;

            do
            {
                password = BankModifyProfileView.takePassword();
            } while (!BankUtil.checkPassword(password));

            Console.WriteLine("Change Password - Press any key");

            Console.ReadKey();

            BankModifyProfileModel.updatePassword(password, user.Username);
        }

        private static void changeAddress(User user)
        {
            Console.Clear();
            Console.WriteLine("Change Address\n\n");
            Thread.Sleep(3000);

            string address;

            do
            {
                address = BankModifyProfileView.takeAddress();
            } while (!BankUtil.checkAddress(address));

            BankModifyProfileModel.updateAddress(address, user.Username);
        }

        private static void changePhoneNumber(User user)
        {
            Console.Clear();
            Console.WriteLine("Change phone number\n\n");

            string phoneNumber;

            do
            {
                phoneNumber = BankModifyProfileView.takePhoneNumber();
            } while (!BankUtil.checkPhoneNumber(phoneNumber));

            BankModifyProfileModel.updatePhoneNumber(phoneNumber, user.Username);
        }

        private static void changeEmail(User user)
        {
            Console.Clear();
            Console.WriteLine("Change Email\n\n");

            string email;

            do
            {
                email = BankModifyProfileView.takeEmail();
            } while (!BankUtil.checkEmail(email));

            BankModifyProfileModel.updateEmail(email, user.Username);
        }
    }
}
