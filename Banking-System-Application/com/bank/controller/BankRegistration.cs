using Banking_System_Application.com.bank.model;
using Banking_System_Application.com.bank.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankRegistration
    {
        private BankRegistration() 
        { }

        public static void Run()
        {
            String username, password, phoneNumber, address, email;
            String[] fullName;
            User user;
            username = registerUsername();
            password = registerPassword();
            fullName = registerName();
            phoneNumber = registerPhoneNumber();
            address = registerAddress();
            email = registerEmail();
            user = new User(username, password, fullName[0], fullName[1], phoneNumber, address, email);
            BankRegistrationModel.saveNewUser(user);
            BankUserProfileView.showWelcome(user);
        }

        public static String registerUsername()
        {
            String username;

            do
            {
                username = BankRegistrationView.takeUsername();
            } while (!checkUsername(username));

            return username;
        }

        public static bool checkUsername(String username) 
        {
            if(username.Count() > 50 || !BankRegistrationModel.checkUniqueUsername(username))
            {
                BankRegistrationView.showWrongUsername();
                return false;
            } else
            {
                return true;
            }
        }

        public static String registerPassword()
        {
            String password;

            do
            {
                password = BankRegistrationView.takePassword();
            } while(!BankUtil.checkPassword(password));

            return password;
        }

        public static String[] registerName()
        {
            String[] fullName = new string[2];

            do
            {
                fullName[0] = BankRegistrationView.takeFirstName();
            } while (!BankUtil.checkName(fullName[0]));

            do
            {
                fullName[1] = BankRegistrationView.takeLastName();
            } while (!BankUtil.checkName(fullName[1]));

            return fullName;
        }

        public static String registerPhoneNumber()
        {
            String phoneNumber;
            do
            {
                phoneNumber = BankRegistrationView.takePhoneNumber();
            } while (!BankUtil.checkPhoneNumber(phoneNumber));

            return phoneNumber;
        }

        public static String registerAddress()
        {
            String address;

            do
            {
                address = BankRegistrationView.takeAddress();
            } while (!BankUtil.checkAddress(address));

            return address;
        }

        public static String registerEmail()
        {
            String email;
            Boolean uniqueEmail;

            do
            {
                email = BankRegistrationView.takeEmail();
                uniqueEmail = BankRegistrationModel.checkUniqueEmail(email);
                if (!uniqueEmail)
                {
                    BankRegistrationView.showUnUniqueEmail();
                }
            } while(!BankUtil.checkEmail(email) || !uniqueEmail);

            return email;
        }
    }
}
